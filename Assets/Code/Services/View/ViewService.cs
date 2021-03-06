using UnityEngine;

public class ViewService : IAssetListener {

//  public static ViewService singleton = new ViewService();

  private Contexts _contexts;
  private Transform _parent;

  public ViewService(Contexts contexts, Transform parent)
  {
    _contexts = contexts;
    _parent = parent;
    contexts.game.CreateEntity().AddAssetListener(this);
  }
//
//  public void Initialize(Contexts contexts, Transform parent) {
//    _contexts = contexts;
//    _parent = parent;
//    contexts.game.CreateEntity().AddAssetListener(this);
////    contexts.game.CreateEntity().AddVisibleListener();
//  }

  public void OnAsset(GameEntity entity, string value) {
    var prefab = Resources.Load<GameObject>($"Prefabs/{value}");
    var view = Object.Instantiate(prefab, _parent).GetComponent<IView>();
    view.Link(entity, _contexts.game);
  }

  
}
