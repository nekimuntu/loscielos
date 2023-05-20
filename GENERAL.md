1 creation d une app react :
7 Mai 2023 

Installation
To start a new Create React App project with TypeScript, you can run:

> npx create-react-app my-app --template typescript
> cd my-app
> npm start


Next step is : Folders structure
/src=>
    /app => /Layout
        => /Api
        => /models
        => /router
        => /store

    /components => /cabins

    /common => /form   
                => /options

    /features   => /cabins
                    => /dashboard
                    => /details
                    => /error
                    => /form

/public => /assets
                =>/images
                    =>/{{cabinname}}

                    ____________________________________________________________________________
                                            11 Mai 2023 
                                            Creation de la solution et des projets sous .NET 
                                            Utilisation d un script 

>git init -b main
>git add. 
>git remote add origin https://github.com/nekimuntu/loscielos.git
# Sets the new remote
> git remote -v
# Verifies the new remote URL

> git push origin main
# Pushes the changes in your local repository up to the remote repository you specified as the origin
                                _____________________________________________________________
                                                Modifier le port du serveur dotnet local

5000 in API/Properties/launchSettings.json 

                                ______________________________________________________________

                                NEXT STEP: CReate the database migration on backend


> dotnet ef migrations add FirstMigration -s API -p Persistence -o Migrations -v

                        ____________________________________________________________________________________
                                    13 mai 2023 
                                    J ai cree le controller et le BaseApiController 

NEXT : creer sur postman les tests api de  get and List 
                        ____________________________________________________________________________________

                                    17 mai 2023 
                                    J ai cree la police des CORS Cross-Origin Requests 
                                    J ai implementer les requetes d'API sur POSTMAN 

NEXT :
1 -  Modifier Cabin class ajouter les proprietes prevues sur le diagramme (https://drawsql.app/teams/kimuntu-team/diagrams/loscielos-simple-diagram)

prevoir la supression et creation d un nouveau fichier Migrations.cs 

2 - Implementer une transaction sql qui modifie la notation des cabines  
                        _____________________________________________________________________________________
                                            Vendredi 19 mai 2023

> dotnet ef -s API -p Persistence database drop 
> dotnet ef migrations -s API -p Persistence remove