using System;
using System.Collections.Generic;


public class BoxRepository {

    Dictionary<int, BoxEntity> all;

    BoxEntity[] temArray;

    public BoxRepository() {
        all = new Dictionary<int, BoxEntity>();
        temArray = new BoxEntity[5];
    }

    public void Add(BoxEntity entity) {
        all.Add(entity.id, entity);
    }

    public void Remove(BoxEntity entity) {
        all.Remove(entity.id);
    }

    public int TakeAll(out BoxEntity[] array) {
        if (all.Count > temArray.Length) {
            temArray = new BoxEntity[all.Count * 2];
        }
        all.Values.CopyTo(temArray, 0);

        array = temArray;
        return all.Count;

    }

    public bool TryGet(int id, out BoxEntity entity) {
        return all.TryGetValue(id, out entity);
    }

    public void Foreach(Action<BoxEntity> action) {
        foreach (var item in all.Values) {
            action(item);
        }
    }
    public BoxEntity Find(Predicate<BoxEntity> predicate) {
        foreach (BoxEntity Box in all.Values) {
            bool isMatch = predicate(Box);

            if (isMatch) {
                return Box;
            }
        }
        return null;
    }

}