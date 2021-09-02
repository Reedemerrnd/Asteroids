using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroids.Data 
{ 
    public static class BuilderExtension2D
    {
        public static T GetOrAddComponent<T>(this GameObject obj) where T : Component
        {
            T result;
            if (!obj.TryGetComponent<T>(out result))
            {
                result = obj.AddComponent<T>();
            }
            return result;
        }

        public static GameObject SetName(this GameObject obj, string name)
        {
            obj.name = name;
            return obj;
        }

        public static GameObject SetCollider<T>(this GameObject obj, bool isTrigger) where T : Collider2D
        {
            obj.GetOrAddComponent<T>().isTrigger = isTrigger;
            return obj;
        }

        public static GameObject AddRigidBody2D(this GameObject obj, float mass, float gravityScale)
        {
            var rigidbody = obj.GetOrAddComponent<Rigidbody2D>();
            rigidbody.mass = mass;
            rigidbody.gravityScale = gravityScale;
            return obj;
        }
        public static GameObject AddRigidBody2D(this GameObject obj,float mass)
        {
            obj.GetOrAddComponent<Rigidbody2D>().mass = mass;
            return obj;
        }

        public static GameObject SetScale(this GameObject obj, float x, float y, float z)
        {
            obj.transform.localScale = new Vector3(x, y, z);
            return obj;
        }

        public static GameObject SetScale(this GameObject obj,Vector3 scale)
        {
            obj.transform.localScale = scale;
            return obj;
        }

        public static GameObject ModScale(this GameObject obj, float mod)
        {
            obj.transform.localScale = obj.transform.localScale * mod;
            return obj;
        }

        public static GameObject SetColor(this GameObject obj, Color color)
        {
            obj.GetOrAddComponent<SpriteRenderer>().material.color = color;
            return obj;
        }

        public static GameObject SetSprite(this GameObject obj, Sprite sprite)
        {
            obj.GetOrAddComponent<SpriteRenderer>().sprite = sprite;
            return obj;
        }
    }
}
