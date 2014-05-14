using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class ExtendedInteractionManager : InteractionManager
    {
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }
            return person;
        }
        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }
        protected void HandleCraftInteraction(string[] commandWords,Person actor)
        {
            bool hasActorHaveIron = false;
            foreach (var item in actor.ListInventory())
            {
                if (item.ItemType == ItemType.Iron)
                {
                    hasActorHaveIron = true;
                }
            }
            bool hasActorHaveWood = false;
            foreach (var item in actor.ListInventory())
            {
                if (item.ItemType == ItemType.Wood)
                {
                    hasActorHaveWood = true;
                }
            }
            if (hasActorHaveIron && hasActorHaveWood)
            {
                bool isNecessaryWeapon = true;
              
                if (isNecessaryWeapon)
                {
                    Weapon w = new Weapon(commandWords[2]);
                    actor.AddToInventory(w);
                    ownerByItem.Add(w, actor);
                }
            }
            if (hasActorHaveIron)
            {
                bool isNecessaryArmor = true;
                
                if (isNecessaryArmor)
                {
                    Armor w = new Armor(commandWords[2]);
                    actor.AddToInventory(w);
                    ownerByItem.Add(w, actor);
                }
            }
        }
        protected void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            if (actor.Location.LocationType == LocationType.Forest)
            {
                bool canGatherFromForest = false;
                foreach (var item in actor.ListInventory())
                {
                    if (item.ItemType == ItemType.Weapon)
                    {
                        canGatherFromForest = true;
                    }
                }
                if (canGatherFromForest)
                {
                    Wood ir = new Wood(commandWords[2]);
                    actor.AddToInventory(ir);
                    this.ownerByItem.Add(ir, actor);
                } 
            }
            else if (actor.Location.LocationType == LocationType.Mine)
            {
                bool canGatherFromMine = false;
                foreach (var item in actor.ListInventory())
                {
                    if (item.ItemType == ItemType.Armor)
                    {
                        canGatherFromMine = true;
                    }
                }
                if (canGatherFromMine)
                {
                    Iron ir = new Iron(commandWords[2]);
                    actor.AddToInventory(ir);
                    this.ownerByItem.Add(ir, actor);
                }
            }

        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "forest":
                    location = new Forest(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }
            return item;
        }
    }
}
