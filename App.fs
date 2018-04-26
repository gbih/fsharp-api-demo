open SuaveRestApi.Rest
open SuaveRestApi.Db

open Suave
open Suave.Web
// open Suave.Successful
// open Suave.Http.Successful

[<EntryPoint>]
let main argv =

    // let albumWEbPart = rest "albums" {
    //     GetAll = MusicStoreDb.getAlbums
    //     GetById = MusicStoreDb.getAlbumById
    //     Create = MusicStoreDb.createAlbum
    //     Update = MusicStoreDb.updateAlbum
    //     UpdateById = MusicStoreDb.updateAlbumById
    //     Delete = MusicStoreDb.deleteAlbum
    //     IsExists = MusicStoreDb.isAlbumExists
    // }


    let personWebPart = rest "people" {
        GetAll = Db.getPeople
        Create = Db.createPerson
        Update = Db.updatePerson
        Delete = Db.deletePerson
        GetById = Db.getPerson
        UpdateById = Db.updatePersonById
        IsExists = Db.isPersonExists
    }

    // let app = choose[personWebPart;albumWebPart]   
 
    startWebServer defaultConfig personWebPart
    0