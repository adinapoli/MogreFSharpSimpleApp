// Ulteriori informazioni su F# all'indirizzo http://fsharp.net

open Mogre
open Mogre.TutorialFramework
open System

type SimpleApp() =
    inherit BaseApplication()

    override this.CreateScene() =
        this.mSceneMgr.AmbientLight <- new ColourValue(1.0f, 1.0f, 1.0f)
        let ent = this.mSceneMgr.CreateEntity("Head", "ogrehead.mesh")
        let node = this.mSceneMgr.RootSceneNode.CreateChildSceneNode("HeadNode")
        node.AttachObject(ent)



let app = new SimpleApp()
app.Go()