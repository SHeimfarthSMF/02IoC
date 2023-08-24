Ziel: Das IoC Prinzip soll anhand der Bibliothek Ninject geübt werden

Die Aufgabe soll in folgenden Teilaufgaben gelöst werden
1. Analyse: Wo ist überall das DI-Prinzip verletzt. Was sind die konkreten Nachteile im Code
    > der RegistrationService erzeugt direkt ein UserRepository, eine DataBaseConnection und einen MailService
    > Nachteile:    
        * Abhängigkeiten sind fest kodiert, sie können nicht einfach ausgetauscht werden 
        * weniger flexibel
        * es ist schwieriger zu managen (insbesondere der ConnectionString für die Datenbank)
        * nicht testbar
        * es können sehr lange Ketten mit Abhängigkeiten entstehen (newA( new B(new C...))=  
2. Refactoring: Zu allen Services sollen Interfaces extrahiert werden. Die Abhängigkeiten sollen über Constructor-Injection injiziert werden.
3. Zur Auflösung der Abhängigkeiten soll die Bibliothek Ninject verwendet werden.
