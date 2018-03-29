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
    using GW2NET.Items.Armors;
    using ItemDTO = GW2NET.V2.Items.Json.ItemDTO;

    public sealed partial class ArmorConverter : IConverter<ItemDTO, Armor>
	{
	    private readonly ITypeConverterFactory<ItemDTO, Armor> converterFactory;

		private ArmorConverter(ITypeConverterFactory<ItemDTO, Armor> converterFactory)
		{
		    if (converterFactory == null)
    		{
    		    throw new ArgumentNullException("converterFactory");
    		}

		    this.converterFactory = converterFactory;
		}

		 /// <inheritdoc />
        Armor IConverter<ItemDTO, Armor>.Convert(ItemDTO value, object state)
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

		// Implement this method in a buddy class to set properties that are specific to 'Armor' (if any)
    	partial void Merge(Armor entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ArmorConverter
		{
		    partial void Merge(Armor entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
	}

#region Boots
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Boots"/>.</summary>
    public sealed partial class BootsConverter : IConverter<ItemDTO, Armor>
    {
	    /// <inheritdoc />
        public Armor Convert(ItemDTO value, object state)
        {
    		var entity = new Boots();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Boots' (if any)
    	partial void Merge(Boots entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class BootsConverter
		{
		    partial void Merge(Boots entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Coat
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Coat"/>.</summary>
    public sealed partial class CoatConverter : IConverter<ItemDTO, Armor>
    {
	    /// <inheritdoc />
        public Armor Convert(ItemDTO value, object state)
        {
    		var entity = new Coat();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Coat' (if any)
    	partial void Merge(Coat entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class CoatConverter
		{
		    partial void Merge(Coat entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Gloves
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Gloves"/>.</summary>
    public sealed partial class GlovesConverter : IConverter<ItemDTO, Armor>
    {
	    /// <inheritdoc />
        public Armor Convert(ItemDTO value, object state)
        {
    		var entity = new Gloves();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Gloves' (if any)
    	partial void Merge(Gloves entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class GlovesConverter
		{
		    partial void Merge(Gloves entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Helm
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Helm"/>.</summary>
    public sealed partial class HelmConverter : IConverter<ItemDTO, Armor>
    {
	    /// <inheritdoc />
        public Armor Convert(ItemDTO value, object state)
        {
    		var entity = new Helm();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Helm' (if any)
    	partial void Merge(Helm entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class HelmConverter
		{
		    partial void Merge(Helm entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region HelmAquatic
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="HelmAquatic"/>.</summary>
    public sealed partial class HelmAquaticConverter : IConverter<ItemDTO, Armor>
    {
	    /// <inheritdoc />
        public Armor Convert(ItemDTO value, object state)
        {
    		var entity = new HelmAquatic();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'HelmAquatic' (if any)
    	partial void Merge(HelmAquatic entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class HelmAquaticConverter
		{
		    partial void Merge(HelmAquatic entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Leggings
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Leggings"/>.</summary>
    public sealed partial class LeggingsConverter : IConverter<ItemDTO, Armor>
    {
	    /// <inheritdoc />
        public Armor Convert(ItemDTO value, object state)
        {
    		var entity = new Leggings();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Leggings' (if any)
    	partial void Merge(Leggings entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class LeggingsConverter
		{
		    partial void Merge(Leggings entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region Shoulders
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="Shoulders"/>.</summary>
    public sealed partial class ShouldersConverter : IConverter<ItemDTO, Armor>
    {
	    /// <inheritdoc />
        public Armor Convert(ItemDTO value, object state)
        {
    		var entity = new Shoulders();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'Shoulders' (if any)
    	partial void Merge(Shoulders entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class ShouldersConverter
		{
		    partial void Merge(Shoulders entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

#region UnknownArmor
    /// <summary>Converts objects of type <see cref="ItemDTO"/> to objects of type <see cref="UnknownArmor"/>.</summary>
    public sealed partial class UnknownArmorConverter : IConverter<ItemDTO, Armor>
    {
	    /// <inheritdoc />
        public Armor Convert(ItemDTO value, object state)
        {
    		var entity = new UnknownArmor();
            this.Merge(entity, value, state);
    		return entity;
        }

    	// Implement this method in a buddy class to set properties that are specific to 'UnknownArmor' (if any)
    	partial void Merge(UnknownArmor entity, ItemDTO dto, object state);

		/*
		// Use this template
		public partial class UnknownArmorConverter
		{
		    partial void Merge(UnknownArmor entity, ItemDTO dto, object state)
			{
			    throw new NotImplementedException();
			}
		}
		*/
    }
#endregion

}
