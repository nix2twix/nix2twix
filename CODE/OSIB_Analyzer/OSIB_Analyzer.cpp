#include <iostream>
#include <Windows.h>
#include <fstream>
#include <filesystem>
#include <stdio.h> 
#include <locale>
#include <string>
#include <regex>
using namespace std;

int main()
{
	system("color F0");
	std::string command;
	char bufferIpconfig[256];
	FILE* pipeIpconfig;
	FILE* pipeFindstr;
	FILE* pipeSysteminfo;
	FILE* pipe;
	LPCWSTR LPcommand = L"cmd.exe /C auditpol /get /category:*";
	HINSTANCE hInstance = ShellExecute(NULL, L"runas", L"cmd.exe", LPcommand, NULL, SW_SHOWNORMAL);

	SetConsoleCP(1251);
	SetConsoleOutputCP(65001);

	ifstream sysInfoFile;
	ofstream infoFile;
	string line;

	int t = 1;

	cout << "\n To get started, select one of the options: ";
	cout << "\n1. System version information.";
	cout << "\n2. Host type and role, DNS and NetBIOS.";
	cout << "\n3. Installed updates according to the Microsoft database.";
	cout << "\nApplied policies:";
	cout << "\n\t\t4. Accounts.";
	cout << "\n\t\t5. Passwords.";
	cout << "\n\t\t6. Audit.";
	cout << "\n7. Network settings (TCP IP), open resources.";
	cout << "\n8. Running services.";
	cout << "\n9. File system.";
	cout << "\n10. Information about installed drivers.";
	cout << "\n0. Exit.";

	cout << "\n\n! The data received about the state of the system will be saved to the output.txt\n"
		<< " file in the directory " << filesystem::current_path();

	while (t != 0)
	{
		cout << "\n\nTo continue working, enter the option number: ";
		cin >> t;
		switch (t)
		{
		case 1:
			// Анализ версии ОС
			system("systeminfo >> output.txt");

			sysInfoFile.open("output.txt");
			while (std::getline(sysInfoFile, line))
			{
				if (line.find("OS Name:") != std::string::npos)
				{
					std::smatch match;
					std::regex pattern(R"((\d+))");
					if (std::regex_search(line, match, pattern))
					{
						int version = std::stoi(match[0]);
						if (version >= 10)
						{
							std::cout << "---> The installed OS version is" + line << "\n";
							std::cout << "---> The installed OS version is current and supported.\n";
						}
						else {
							std::cout << "---> It is recommended to upgrade the OS version to 10 and above.\n";
						}
					}
					break;
				}
			}
			sysInfoFile.close();

			break;

		case 2:
		
			// Анализ конфигурации DNS
			system("ipconfig /all >> output.txt");

			sysInfoFile.open("output.txt");
			while (std::getline(sysInfoFile, line)) {
				if (line.find("DNS Servers") != std::string::npos) {
					std::regex pattern("\\b(?:\\d{1,3}\\.){3}\\d{1,3}\\b|\\b(?:[0-9a-fA-F]{0,4}:){2,7}[0-9a-fA-F]{0,4}%\\d+\\b");
					std::sregex_iterator it(line.begin(), line.end(), pattern);
					std::sregex_iterator end;

					for (; it != end; ++it) {
						std::cout << "DNS Server found: " << it->str() << std::endl;
					}
				}
			}
			std::cout << "It is recommended to include advanced DNS security features, "
				<< "such as DNS Security Extensions(DNSSEC).";
			sysInfoFile.close();
			cout << "\n--------------------------------------------------------\n";
			// Анализ конфигурации NetBIOS
			system("nbtstat -n >> output.txt");

			sysInfoFile.open("output.txt");
			while (std::getline(sysInfoFile, line)) 
			{
				if (line.find("NetBIOS over Tcpip") != std::string::npos) 
				{
					std::smatch match;
					std::regex pattern(":\\s*(\\w+)");
					if (std::regex_search(line, match, pattern)) {
						std::cout << "Reconmmend to disable NetBIOS over Tcpip.\n";
					}
					else {
						std::cout << "No action needed.\n";
					}
					break;
				}
			}
			sysInfoFile.close();


			cout << "\n--------------------------------------------------------\n";

			// Анализ типа и роли узла
			system("nltest /dsgetdc >> output.txt 2> nul");

			sysInfoFile.open("output.txt");
			while (std::getline(sysInfoFile, line))
			{
				if (line.find("Node Type") != std::string::npos) {
					if (line == "   Node Type . . . . . . . . . . . . : Broadcast") {
						std::cout << "The installed Node Type is Broadcast - no action needed.\n";
					}
					else if (line == "   Node Type . . . . . . . . . . . . : Peer to Peer") {
						std::cout << "The installed Node Type is Peer to Peer - consider changing to Hybrid.\n";
					}
					else if (line == "   Node Type . . . . . . . . . . . . : Mixed") {
						std::cout << "The installed Node Type is Mixed - consider changing to Hybrid.\n";
					}
					else if (line == "   Node Type . . . . . . . . . . . . : Hybrid") {
						std::cout << "The installed Node Type is Hybrid - no action needed.\n";
					}
					else {
						std::cout << "Unknown Node Type found.\n";
					}
					break;
				}
			}
			sysInfoFile.close();

			break;
		
		case 3:
			system("wmic qfe list >> output.txt");
			system("wmic qfe list");
			std::cout << "It is recommended to regularly check and install operating system "
				<< "and software updates to eliminate vulnerabilities.";

			break;
		case 4:
			system("net localgroup Администраторы");
			cout << "\n--------------------------------------------------------\n";

			system("gpresult /Scope User /v");
			std::cout << "\nBy default, it is recommended to minimize the number of accounts "
				<< "with high privileges, that is, use the principle of least privileges and "
				<< "restrict access to administrative accounts.";

			break;

		case 5:
			system("net accounts");
			std::cout << "It is recommended to set complex passwords using a combination of letters,"
				<< " numbers and symbols without semantic bindings to user data. Passwords are valid"
				<< " for no more than 1 month. The password is at least 8 characters long.";
			std::cout << "Use commands:\n net accounts /minpwlen:8\nnet accounts /maxpwage:30\nnet accounts /minpwage:0";
			break;

		case 6:
			ShellExecute(nullptr, L"runas", L"cmd.exe", L"/K auditpol /get /category:*", nullptr, SW_SHOWNORMAL);

			std::cout << "It is recommended to enable auditing for important events, such as "
				<< " failed login attempts, account changes, etc., as well as regularly check audit logs.";
			std::cout << "Use commands:\n auditpol /set /subcategory:\"Logon\" /failure:enable\n"
				<< "auditpol /set /subcategory:\"User Account Management\" /success:enable /failure:enable\n"
				<< "auditpol /set /subcategory:\"Object Access\" /success:enable /failure:enable\n"
				<< "auditpol /list /subcategory:\"Object Access\"";
				break;

		case 7:
			system("ipconfig /all");
			std::cout << "It is recommended to limit the use of legacy protocols, enable a firewall, "
				<< "and use network segments to isolate various parts of the network.";
			std::cout << "Use commands:\nnetsh interface tcp set global netbios-option=disabled\n"
				<< "netsh interface ipv6 set interface \"Имя_интерфейса\" routerdiscovery=disable\n"
				<< "netsh interface ipv6 uninstall\n"
				<< "netsh interface ipv6 set global randomizeidentifiers=disabled\n"
				<< "netsh advfirewall set allprofiles firewallpolicy blockinbound,allowoutbound\n"
				<< "netsh firewall set service type=FILEANDPRINT mode=DISABLE\n"
				<< "sc config RemoteRegistry start=disabled\n"
				<< "reg add HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip6\\Parameters /v DisabledComponents /t REG_DWORD /d 0xFFFFFFFF /f";
			break;

		case 8:
			system("net start");
			std::cout << "It is recommended to disable unnecessary services, as well as "
				<< "regularly check running services for vulnerabilities.";
			break;

		case 9:
			system("diskmgmt");
			std::cout << "It is recommended to use NTFS and apply the principle of least privilege when configuring access rights. "
				<< "Regularly audit critical files and folders for unusual activity.";
			break;
		case 10: system("driverquery >> output.txt");
			system("driverquery");
			std::cout << "It is recommended to use only signed drivers from trusted sources and regularly update "
				<< "drivers to eliminate vulnerabilities.";
			break;

		case 0: break;
		default: cout << "Error! No option found\n"; break;
		}
	}
	return 0;
}

/*
#include <iostream>
#include <Windows.h>
#include <fstream>
#include <filesystem>
#include <stdio.h>
#include <locale>
#include <string>
#include <regex>
using namespace std;

int main()
{

	ofstream infoFile("output.txt", std::ios::out | std::ios::binary);

	//SetConsoleCP(1251);
	//SetConsoleOutputCP(1251);

	std::string command;
	char bufferIpconfig[256];
	FILE* pipeIpconfig;
	FILE* pipeFindstr;
	FILE* pipeSysteminfo;
	FILE* pipe;
	std::wstring wcommand;

	ifstream sysInfoFile("output.txt");
	string line;

	int t = 1;

	cout << "\n To get started, select one of the options: ";
	cout << "\n1. System version information.";
	cout << "\n2. Host type and role, DNS and NetBIOS.";
	cout << "\n3. Installed updates according to the Microsoft database.";
	cout << "\n4. Applied policies:";
	cout << "\n\t\t- Accounts.";
	cout << "\n\t\t- Passwords.";
	cout << "\n\t\t- Audit.";
	cout << "\n7. Network settings (TCP IP), open resources.";
	cout << "\n8. Running services.";
	cout << "\n9. File system.";
	cout << "\n10. Information about installed drivers.";
	cout << "\n0. Exit.";

	cout << "\n\n! The data received about the state of the system will be saved to the output.txt\n"
		<< " file in the directory " << filesystem::current_path();

	while (t != 0)
	{
		_putenv("LANG=en");
		cout << "\n\nTo continue working, enter the option number: ";
		cin >> t;
		switch (t)
		{
		case 1:
			system("systeminfo");
			command = "systeminfo";
			pipe = _popen(command.c_str(), "r");

			char bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipe) != NULL)
			{
				infoFile << bufferIpconfig;
			}

			infoFile.close();
			_pclose(pipe);

			while (std::getline(sysInfoFile, line))
			{
				if (line.find("OS Name:") != std::string::npos)
				{
					std::smatch match;
					std::regex pattern(R"((\d+))");
					if (std::regex_search(line, match, pattern))
					{
						int version = std::stoi(match[0]);
						if (version >= 10)
						{
							std::cout << "---> The installed OS version is current and supported.\n";
						}
						else {
							std::cout << "---> It is recommended to upgrade the OS version to 10 and above.\n";
						}
					}
					break;
				}
			}

			break;

		case 2:

			//system("ipconfig /all");
			command = "ipconfig /all";
			pipeIpconfig = _popen(command.c_str(), "r");

			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != nullptr)
			{
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);

			cout << "\n--------------------------------------------------------\n";

			//system("systeminfo");
			command = "systeminfo";
			pipeSysteminfo = _popen(command.c_str(), "r");

			char bufferSysteminfo[128];
			while (fgets(bufferSysteminfo, sizeof(bufferSysteminfo), pipeSysteminfo) != NULL) {
				infoFile << bufferSysteminfo;
			}
			_pclose(pipeSysteminfo);

			cout << "\n--------------------------------------------------------\n";

			system("ipconfig /all | findstr /R \"DNS Servers\"");
			wcommand = L"chcp 65001 & ipconfig /all | findstr /R \"DNS Servers\"";
			pipeFindstr = _wpopen(wcommand.c_str(), L"rt, ccs=UTF-8");

			char bufferFindstr[128];
			while (fgets(bufferFindstr, sizeof(bufferFindstr), pipeFindstr) != NULL) {
				infoFile << bufferFindstr;
			}

			infoFile.close();
			_pclose(pipeFindstr);

			break;
		case 3:
			system("wmic qfe list");
			command = "wmic qfe list";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);
			break;
		case 4:
			system("net localgroup Администраторы");
			command = "net localgroup Администраторы";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);


			cout << "\n--------------------------------------------------------\n";

			system("gpresult /Scope User /v");
			command = "gpresult /Scope User /v";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);

			break;

		case 5:
			system("net accounts");
			command = "net accounts";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);
			break;

		case 6:
			system("auditpol /get /category:*");
			command = "auditpol /get /category:*";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);
			break;

		case 7:
			system("ipconfig /all");
			command = "ipconfig /all";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);
			break;

		case 8:
			system("services");
			command = "services";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);
			break;

		case 9:
			system("diskmgmt"); //system("icacls C:/Windows/System32"); break;
			command = "diskmgmt";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);
			break;
		case 10: system("driverquery");
			command = "driverquery";
			pipeIpconfig = _popen(command.c_str(), "r");

			bufferIpconfig[128];
			while (fgets(bufferIpconfig, sizeof(bufferIpconfig), pipeIpconfig) != NULL) {
				infoFile << bufferIpconfig;
			}
			_pclose(pipeIpconfig);
			break;

		case 0: break;
		default: cout << "Ошибка! Нет такой опции\n"; break;
		}
	}
	return 0;
}*/