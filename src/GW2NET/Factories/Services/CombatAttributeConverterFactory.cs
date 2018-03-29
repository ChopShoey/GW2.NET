// <copyright file="CombatAttributeConverterFactory.cs" company="GW2.NET Coding Team">
// This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>

namespace GW2NET.Factories.Services
{
    using System.Diagnostics;
    using Common;
    using GW2NET.V2.Items.Converters;
    using GW2NET.V2.Items.Json;
    using Items.Common;

    public class CombatAttributeConverterFactory : ITypeConverterFactory<AttributeDTO, CombatAttribute>
    {
        public IConverter<AttributeDTO, CombatAttribute> Create(string discriminator)
        {
            switch (discriminator)
            {
                case "AgonyResistance":
                    return new AgonyResistanceModifierConverter();
                case "ConditionDamage":
                    return new ConditionDamageModifierConverter();
                case "CritDamage":
                    return new FerocityModifierConverter();
                case "Healing":
                    return new HealingModifierConverter();
                case "Power":
                    return new PowerModifierConverter();
                case "Precision":
                    return new PrecisionModifierConverter();
                case "Toughness":
                    return new ToughnessModifierConverter();
                case "Vitality":
                    return new VitalityModifierConverter();
                case "BoonDuration":
                    return new ConcentrationModifierConverter();
                case "ConditionDuration":
                    return new ExpertiseModifierConverter();
                default:
                    Debug.Assert(false, "Unknown type discriminator: " + discriminator);
                    return new UnknownModifierConverter();
            }
        }
    }
}