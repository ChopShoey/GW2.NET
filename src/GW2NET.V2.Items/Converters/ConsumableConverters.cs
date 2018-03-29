﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GW2NET.V2.Items.Converters
{
    using System;

    using GW2NET.Common;
    using GW2NET.Items;
    using GW2NET.Items.Consumables;
    using ItemDTO = GW2NET.V2.Items.Json.ItemDTO;

    public sealed partial class ConsumableConverter : IConverter<ItemDTO, Consumable>
	{
	    private readonly ITypeConverterFactory<ItemDTO, Consumable> converterFactory;

		public ConsumableConverter(ITypeConverterFactory<ItemDTO, Consumable> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        Consumable IConverter<ItemDTO, Consumable>.Convert(ItemDTO value, object state)
		{
		    if (value == null)
    		{
    		    throw new ArgumentNullException("value");
    		}

			string discriminator = value.Details.Type;
			var converter = this.converterFactory.Create(discriminator);
			var entity = converter.Convert(value, value);
			this.Merge(entity, value, state);
			return entity;
		}

		// Implement this method in a buddy class to set properties that are specific to 'Consumable' (if any)
    	partial void Merge(Consumable entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ConsumableConverter
		{
		    partial void Merge(Consumable entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region RandomUnlock
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="RandomUnlock"/>.</summary>
    public sealed partial class RandomUnlockConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new RandomUnlock();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'RandomUnlock' (if any)
    	partial void Merge(RandomUnlock entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class RandomUnlockConverter
		{
		    partial void Merge(RandomUnlock entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region TeleportToFriend
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="TeleportToFriend"/>.</summary>
    public sealed partial class TeleportToFriendConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new TeleportToFriend();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'TeleportToFriend' (if any)
    	partial void Merge(TeleportToFriend entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class TeleportToFriendConverter
		{
		    partial void Merge(TeleportToFriend entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Alcohol
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Alcohol"/>.</summary>
    public sealed partial class AlcoholConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new Alcohol();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Alcohol' (if any)
    	partial void Merge(Alcohol entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class AlcoholConverter
		{
		    partial void Merge(Alcohol entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region AppearanceChanger
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="AppearanceChanger"/>.</summary>
    public sealed partial class AppearanceChangerConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new AppearanceChanger();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'AppearanceChanger' (if any)
    	partial void Merge(AppearanceChanger entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class AppearanceChangerConverter
		{
		    partial void Merge(AppearanceChanger entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region ContractNpc
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="ContractNpc"/>.</summary>
    public sealed partial class ContractNpcConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new ContractNpc();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'ContractNpc' (if any)
    	partial void Merge(ContractNpc entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ContractNpcConverter
		{
		    partial void Merge(ContractNpc entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Food
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Food"/>.</summary>
    public sealed partial class FoodConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new Food();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Food' (if any)
    	partial void Merge(Food entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class FoodConverter
		{
		    partial void Merge(Food entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region GenericConsumable
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="GenericConsumable"/>.</summary>
    public sealed partial class GenericConsumableConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new GenericConsumable();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'GenericConsumable' (if any)
    	partial void Merge(GenericConsumable entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class GenericConsumableConverter
		{
		    partial void Merge(GenericConsumable entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region HalloweenConsumable
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="HalloweenConsumable"/>.</summary>
    public sealed partial class HalloweenConsumableConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new HalloweenConsumable();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'HalloweenConsumable' (if any)
    	partial void Merge(HalloweenConsumable entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class HalloweenConsumableConverter
		{
		    partial void Merge(HalloweenConsumable entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region ImmediateConsumable
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="ImmediateConsumable"/>.</summary>
    public sealed partial class ImmediateConsumableConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new ImmediateConsumable();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'ImmediateConsumable' (if any)
    	partial void Merge(ImmediateConsumable entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ImmediateConsumableConverter
		{
		    partial void Merge(ImmediateConsumable entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Transmutation
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Transmutation"/>.</summary>
    public sealed partial class TransmutationConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new Transmutation();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Transmutation' (if any)
    	partial void Merge(Transmutation entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class TransmutationConverter
		{
		    partial void Merge(Transmutation entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownConsumable
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="UnknownConsumable"/>.</summary>
    public sealed partial class UnknownConsumableConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new UnknownConsumable();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'UnknownConsumable' (if any)
    	partial void Merge(UnknownConsumable entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownConsumableConverter
		{
		    partial void Merge(UnknownConsumable entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnTransmutation
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="UnTransmutation"/>.</summary>
    public sealed partial class UnTransmutationConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new UnTransmutation();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'UnTransmutation' (if any)
    	partial void Merge(UnTransmutation entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UnTransmutationConverter
		{
		    partial void Merge(UnTransmutation entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UpgradeRemoval
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="UpgradeRemoval"/>.</summary>
    public sealed partial class UpgradeRemovalConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new UpgradeRemoval();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'UpgradeRemoval' (if any)
    	partial void Merge(UpgradeRemoval entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UpgradeRemovalConverter
		{
		    partial void Merge(UpgradeRemoval entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Utility
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Utility"/>.</summary>
    public sealed partial class UtilityConverter : IConverter<ItemDTO, Consumable>
    {
	    /// <inheritdoc />
        public Consumable Convert(ItemDTO value, object state)
        {
    		var entity = new Utility();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Utility' (if any)
    	partial void Merge(Utility entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UtilityConverter
		{
		    partial void Merge(Utility entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}
