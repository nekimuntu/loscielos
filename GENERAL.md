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