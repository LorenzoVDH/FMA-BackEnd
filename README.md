Fleet Manager Application 

Works on Windows with Visual Studio 2022 

1. Install all the dependencies 

2. In Visual Studio 2022, configure the following startup projects: 

	1. FleetManager.IdentityServer (which is needed for configuring the Loginsystem and RBAC) 
	2. FleetManager.ReadAPI + FleetManager.WriteAPI 

	3. (optional) FleetManager.MAUIFront 
		A simple mobile frontend made in MAUI. 
		An Android emulator is needed to start this project. 
		Before starting the solution, the emulator must be running. Some test login credentials: 

		markgarner@fleetman.com
		ThisIsMyPassword1234
		
		fishergirl337@fleetman.com
		ilikepancakes2000
		
		xx_justlisa_xx@fleetman.com
		abcABC123
