/*
 *
 *	< IFC - ISO 10303 (STEP) Part 21 instance file reader >
 *	Copyright (C) <2012>  <Donghoon Yang>
 *
 *	This program is free software: you can redistribute it and/or modify
 *	it under the terms of the GNU General Public License as published by
 *	the Free Software Foundation, either version 3 of the License, or
 *	(at your option) any later version.
 *
 *	This program is distributed in the hope that it will be useful,
 *	but WITHOUT ANY WARRANTY; without even the implied warranty of
 *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *	GNU General Public License for more details.
 *
 *	You should have received a copy of the GNU General Public License
 *	along with this program.  If not, see <http://www.gnu.org/licenses/>. 
 *
 *
 *	This file is generated with SchemaModel.SData.CSharpClassMaker
 *	included in this program.
 *
 */



using System;
using System.IO;
using System.Collections.Generic;
using EbInstanceModel;


namespace IFC4
{

	public partial class IfcAbsorbedDoseMeasure : REAL
	{
		public IfcAbsorbedDoseMeasure(){}

		{
			return new IfcAbsorbedDoseMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAbsorbedDoseMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAccelerationMeasure : REAL
	{
		public IfcAccelerationMeasure(){}

		{
			return new IfcAccelerationMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAccelerationMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAmountOfSubstanceMeasure : REAL
	{
		public IfcAmountOfSubstanceMeasure(){}

		{
			return new IfcAmountOfSubstanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAmountOfSubstanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAngularVelocityMeasure : REAL
	{
		public IfcAngularVelocityMeasure(){}

		{
			return new IfcAngularVelocityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAngularVelocityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAreaDensityMeasure : REAL
	{
		public IfcAreaDensityMeasure(){}

		{
			return new IfcAreaDensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAreaDensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcAreaMeasure : REAL
	{
		public IfcAreaMeasure(){}

		{
			return new IfcAreaMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcAreaMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcBoolean : BOOLEAN
	{
		public IfcBoolean(){}

		{
			return new IfcBoolean{ Value = value };
		}
		public static implicit operator bool(IfcBoolean obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcBoxAlignment : IfcLabel
	{
		public static implicit operator IfcBoxAlignment(string value)
		{
			return new IfcBoxAlignment{ Value = value };
		}
		public static implicit operator string(IfcBoxAlignment obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcCardinalPointReference : INTEGER
	{
		public IfcCardinalPointReference(){}

		{
			return new IfcCardinalPointReference{ Value = value };
		}
		public static implicit operator int(IfcCardinalPointReference obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcComplexNumber : List<REAL>
	{
		public bool IsDerived;
	}

	public partial class IfcCompoundPlaneAngleMeasure : List<INTEGER>
	{
		public bool IsDerived;
	}

	public partial class IfcContextDependentMeasure : REAL
	{
		public IfcContextDependentMeasure(){}

		{
			return new IfcContextDependentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcContextDependentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcCountMeasure : NUMBER
	{
		public IfcCountMeasure(){}

		{
			return new IfcCountMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcCountMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcCurvatureMeasure : REAL
	{
		public IfcCurvatureMeasure(){}

		{
			return new IfcCurvatureMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcCurvatureMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDate : STRING
	{
		public IfcDate(){}

		{
			return new IfcDate{ Value = value };
		}
		public static implicit operator string(IfcDate obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDateTime : STRING
	{
		public IfcDateTime(){}

		{
			return new IfcDateTime{ Value = value };
		}
		public static implicit operator string(IfcDateTime obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDayInMonthNumber : INTEGER
	{
		public IfcDayInMonthNumber(){}

		{
			return new IfcDayInMonthNumber{ Value = value };
		}
		public static implicit operator int(IfcDayInMonthNumber obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDayInWeekNumber : INTEGER
	{
		public IfcDayInWeekNumber(){}

		{
			return new IfcDayInWeekNumber{ Value = value };
		}
		public static implicit operator int(IfcDayInWeekNumber obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDescriptiveMeasure : STRING
	{
		public IfcDescriptiveMeasure(){}

		{
			return new IfcDescriptiveMeasure{ Value = value };
		}
		public static implicit operator string(IfcDescriptiveMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDimensionCount : INTEGER
	{
		public IfcDimensionCount(){}

		{
			return new IfcDimensionCount{ Value = value };
		}
		public static implicit operator int(IfcDimensionCount obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDoseEquivalentMeasure : REAL
	{
		public IfcDoseEquivalentMeasure(){}

		{
			return new IfcDoseEquivalentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcDoseEquivalentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDuration : STRING
	{
		public IfcDuration(){}

		{
			return new IfcDuration{ Value = value };
		}
		public static implicit operator string(IfcDuration obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcDynamicViscosityMeasure : REAL
	{
		public IfcDynamicViscosityMeasure(){}

		{
			return new IfcDynamicViscosityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcDynamicViscosityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricCapacitanceMeasure : REAL
	{
		public IfcElectricCapacitanceMeasure(){}

		{
			return new IfcElectricCapacitanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricCapacitanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricChargeMeasure : REAL
	{
		public IfcElectricChargeMeasure(){}

		{
			return new IfcElectricChargeMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricChargeMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricConductanceMeasure : REAL
	{
		public IfcElectricConductanceMeasure(){}

		{
			return new IfcElectricConductanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricConductanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricCurrentMeasure : REAL
	{
		public IfcElectricCurrentMeasure(){}

		{
			return new IfcElectricCurrentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricCurrentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricResistanceMeasure : REAL
	{
		public IfcElectricResistanceMeasure(){}

		{
			return new IfcElectricResistanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricResistanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcElectricVoltageMeasure : REAL
	{
		public IfcElectricVoltageMeasure(){}

		{
			return new IfcElectricVoltageMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcElectricVoltageMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcEnergyMeasure : REAL
	{
		public IfcEnergyMeasure(){}

		{
			return new IfcEnergyMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcEnergyMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcFontStyle : STRING
	{
		public IfcFontStyle(){}

		{
			return new IfcFontStyle{ Value = value };
		}
		public static implicit operator string(IfcFontStyle obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcFontVariant : STRING
	{
		public IfcFontVariant(){}

		{
			return new IfcFontVariant{ Value = value };
		}
		public static implicit operator string(IfcFontVariant obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcFontWeight : STRING
	{
		public IfcFontWeight(){}

		{
			return new IfcFontWeight{ Value = value };
		}
		public static implicit operator string(IfcFontWeight obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcForceMeasure : REAL
	{
		public IfcForceMeasure(){}

		{
			return new IfcForceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcForceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcFrequencyMeasure : REAL
	{
		public IfcFrequencyMeasure(){}

		{
			return new IfcFrequencyMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcFrequencyMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcGloballyUniqueId : STRING
	{
		public IfcGloballyUniqueId(){}

		{
			return new IfcGloballyUniqueId{ Value = value };
		}
		public static implicit operator string(IfcGloballyUniqueId obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcHeatFluxDensityMeasure : REAL
	{
		public IfcHeatFluxDensityMeasure(){}

		{
			return new IfcHeatFluxDensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcHeatFluxDensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcHeatingValueMeasure : REAL
	{
		public IfcHeatingValueMeasure(){}

		{
			return new IfcHeatingValueMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcHeatingValueMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIdentifier : STRING
	{
		public IfcIdentifier(){}

		{
			return new IfcIdentifier{ Value = value };
		}
		public static implicit operator string(IfcIdentifier obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIlluminanceMeasure : REAL
	{
		public IfcIlluminanceMeasure(){}

		{
			return new IfcIlluminanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcIlluminanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcInductanceMeasure : REAL
	{
		public IfcInductanceMeasure(){}

		{
			return new IfcInductanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcInductanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcInteger : INTEGER
	{
		public IfcInteger(){}

		{
			return new IfcInteger{ Value = value };
		}
		public static implicit operator int(IfcInteger obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIntegerCountRateMeasure : INTEGER
	{
		public IfcIntegerCountRateMeasure(){}

		{
			return new IfcIntegerCountRateMeasure{ Value = value };
		}
		public static implicit operator int(IfcIntegerCountRateMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIonConcentrationMeasure : REAL
	{
		public IfcIonConcentrationMeasure(){}

		{
			return new IfcIonConcentrationMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcIonConcentrationMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcIsothermalMoistureCapacityMeasure : REAL
	{
		public IfcIsothermalMoistureCapacityMeasure(){}

		{
			return new IfcIsothermalMoistureCapacityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcIsothermalMoistureCapacityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcKinematicViscosityMeasure : REAL
	{
		public IfcKinematicViscosityMeasure(){}

		{
			return new IfcKinematicViscosityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcKinematicViscosityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLabel : STRING
	{
		public IfcLabel(){}

		{
			return new IfcLabel{ Value = value };
		}
		public static implicit operator string(IfcLabel obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLanguageId : IfcIdentifier
	{
		public static implicit operator IfcLanguageId(string value)
		{
			return new IfcLanguageId{ Value = value };
		}
		public static implicit operator string(IfcLanguageId obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLengthMeasure : REAL
	{
		public IfcLengthMeasure(){}

		{
			return new IfcLengthMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLengthMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLinearForceMeasure : REAL
	{
		public IfcLinearForceMeasure(){}

		{
			return new IfcLinearForceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLinearForceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLinearMomentMeasure : REAL
	{
		public IfcLinearMomentMeasure(){}

		{
			return new IfcLinearMomentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLinearMomentMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLinearStiffnessMeasure : REAL
	{
		public IfcLinearStiffnessMeasure(){}

		{
			return new IfcLinearStiffnessMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLinearStiffnessMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLinearVelocityMeasure : REAL
	{
		public IfcLinearVelocityMeasure(){}

		{
			return new IfcLinearVelocityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLinearVelocityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLogical : LOGICAL
	{
		public IfcLogical(){}

		{
			return new IfcLogical{ Value = value };
		}
		public static implicit operator int(IfcLogical obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLuminousFluxMeasure : REAL
	{
		public IfcLuminousFluxMeasure(){}

		{
			return new IfcLuminousFluxMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLuminousFluxMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLuminousIntensityDistributionMeasure : REAL
	{
		public IfcLuminousIntensityDistributionMeasure(){}

		{
			return new IfcLuminousIntensityDistributionMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLuminousIntensityDistributionMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcLuminousIntensityMeasure : REAL
	{
		public IfcLuminousIntensityMeasure(){}

		{
			return new IfcLuminousIntensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcLuminousIntensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMagneticFluxDensityMeasure : REAL
	{
		public IfcMagneticFluxDensityMeasure(){}

		{
			return new IfcMagneticFluxDensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMagneticFluxDensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMagneticFluxMeasure : REAL
	{
		public IfcMagneticFluxMeasure(){}

		{
			return new IfcMagneticFluxMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMagneticFluxMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMassDensityMeasure : REAL
	{
		public IfcMassDensityMeasure(){}

		{
			return new IfcMassDensityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMassDensityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMassFlowRateMeasure : REAL
	{
		public IfcMassFlowRateMeasure(){}

		{
			return new IfcMassFlowRateMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMassFlowRateMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMassMeasure : REAL
	{
		public IfcMassMeasure(){}

		{
			return new IfcMassMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMassMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMassPerLengthMeasure : REAL
	{
		public IfcMassPerLengthMeasure(){}

		{
			return new IfcMassPerLengthMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMassPerLengthMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcModulusOfElasticityMeasure : REAL
	{
		public IfcModulusOfElasticityMeasure(){}

		{
			return new IfcModulusOfElasticityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcModulusOfElasticityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcModulusOfLinearSubgradeReactionMeasure : REAL
	{
		public IfcModulusOfLinearSubgradeReactionMeasure(){}

		{
			return new IfcModulusOfLinearSubgradeReactionMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcModulusOfLinearSubgradeReactionMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcModulusOfRotationalSubgradeReactionMeasure : REAL
	{
		public IfcModulusOfRotationalSubgradeReactionMeasure(){}

		{
			return new IfcModulusOfRotationalSubgradeReactionMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcModulusOfRotationalSubgradeReactionMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcModulusOfSubgradeReactionMeasure : REAL
	{
		public IfcModulusOfSubgradeReactionMeasure(){}

		{
			return new IfcModulusOfSubgradeReactionMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcModulusOfSubgradeReactionMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMoistureDiffusivityMeasure : REAL
	{
		public IfcMoistureDiffusivityMeasure(){}

		{
			return new IfcMoistureDiffusivityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMoistureDiffusivityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMolecularWeightMeasure : REAL
	{
		public IfcMolecularWeightMeasure(){}

		{
			return new IfcMolecularWeightMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMolecularWeightMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMomentOfInertiaMeasure : REAL
	{
		public IfcMomentOfInertiaMeasure(){}

		{
			return new IfcMomentOfInertiaMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMomentOfInertiaMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMonetaryMeasure : REAL
	{
		public IfcMonetaryMeasure(){}

		{
			return new IfcMonetaryMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcMonetaryMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcMonthInYearNumber : INTEGER
	{
		public IfcMonthInYearNumber(){}

		{
			return new IfcMonthInYearNumber{ Value = value };
		}
		public static implicit operator int(IfcMonthInYearNumber obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcNonNegativeLengthMeasure : IfcLengthMeasure
	{
		public static implicit operator IfcNonNegativeLengthMeasure(double value)
		{
			return new IfcNonNegativeLengthMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcNonNegativeLengthMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcNormalisedRatioMeasure : IfcRatioMeasure
	{
		public static implicit operator IfcNormalisedRatioMeasure(double value)
		{
			return new IfcNormalisedRatioMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcNormalisedRatioMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcNumericMeasure : NUMBER
	{
		public IfcNumericMeasure(){}

		{
			return new IfcNumericMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcNumericMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPHMeasure : REAL
	{
		public IfcPHMeasure(){}

		{
			return new IfcPHMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPHMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcParameterValue : REAL
	{
		public IfcParameterValue(){}

		{
			return new IfcParameterValue{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcParameterValue obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPlanarForceMeasure : REAL
	{
		public IfcPlanarForceMeasure(){}

		{
			return new IfcPlanarForceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPlanarForceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPlaneAngleMeasure : REAL
	{
		public IfcPlaneAngleMeasure(){}

		{
			return new IfcPlaneAngleMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPlaneAngleMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPositiveLengthMeasure : IfcLengthMeasure
	{
		public static implicit operator IfcPositiveLengthMeasure(double value)
		{
			return new IfcPositiveLengthMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPositiveLengthMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPositivePlaneAngleMeasure : IfcPlaneAngleMeasure
	{
		public static implicit operator IfcPositivePlaneAngleMeasure(double value)
		{
			return new IfcPositivePlaneAngleMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPositivePlaneAngleMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPositiveRatioMeasure : IfcRatioMeasure
	{
		public static implicit operator IfcPositiveRatioMeasure(double value)
		{
			return new IfcPositiveRatioMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPositiveRatioMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPowerMeasure : REAL
	{
		public IfcPowerMeasure(){}

		{
			return new IfcPowerMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPowerMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPresentableText : STRING
	{
		public IfcPresentableText(){}

		{
			return new IfcPresentableText{ Value = value };
		}
		public static implicit operator string(IfcPresentableText obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPressureMeasure : REAL
	{
		public IfcPressureMeasure(){}

		{
			return new IfcPressureMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcPressureMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcPropertySetDefinitionSet : List<IfcPropertySetDefinition>
	{
		public bool IsDerived;
	}

	public partial class IfcRadioActivityMeasure : REAL
	{
		public IfcRadioActivityMeasure(){}

		{
			return new IfcRadioActivityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRadioActivityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRatioMeasure : REAL
	{
		public IfcRatioMeasure(){}

		{
			return new IfcRatioMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRatioMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcReal : REAL
	{
		public IfcReal(){}

		{
			return new IfcReal{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcReal obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRotationalFrequencyMeasure : REAL
	{
		public IfcRotationalFrequencyMeasure(){}

		{
			return new IfcRotationalFrequencyMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRotationalFrequencyMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRotationalMassMeasure : REAL
	{
		public IfcRotationalMassMeasure(){}

		{
			return new IfcRotationalMassMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRotationalMassMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcRotationalStiffnessMeasure : REAL
	{
		public IfcRotationalStiffnessMeasure(){}

		{
			return new IfcRotationalStiffnessMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcRotationalStiffnessMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSectionModulusMeasure : REAL
	{
		public IfcSectionModulusMeasure(){}

		{
			return new IfcSectionModulusMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSectionModulusMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSectionalAreaIntegralMeasure : REAL
	{
		public IfcSectionalAreaIntegralMeasure(){}

		{
			return new IfcSectionalAreaIntegralMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSectionalAreaIntegralMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcShearModulusMeasure : REAL
	{
		public IfcShearModulusMeasure(){}

		{
			return new IfcShearModulusMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcShearModulusMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSolidAngleMeasure : REAL
	{
		public IfcSolidAngleMeasure(){}

		{
			return new IfcSolidAngleMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSolidAngleMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSoundPowerLevelMeasure : REAL
	{
		public IfcSoundPowerLevelMeasure(){}

		{
			return new IfcSoundPowerLevelMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSoundPowerLevelMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSoundPowerMeasure : REAL
	{
		public IfcSoundPowerMeasure(){}

		{
			return new IfcSoundPowerMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSoundPowerMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSoundPressureLevelMeasure : REAL
	{
		public IfcSoundPressureLevelMeasure(){}

		{
			return new IfcSoundPressureLevelMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSoundPressureLevelMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSoundPressureMeasure : REAL
	{
		public IfcSoundPressureMeasure(){}

		{
			return new IfcSoundPressureMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSoundPressureMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSpecificHeatCapacityMeasure : REAL
	{
		public IfcSpecificHeatCapacityMeasure(){}

		{
			return new IfcSpecificHeatCapacityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSpecificHeatCapacityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSpecularExponent : REAL
	{
		public IfcSpecularExponent(){}

		{
			return new IfcSpecularExponent{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSpecularExponent obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcSpecularRoughness : REAL
	{
		public IfcSpecularRoughness(){}

		{
			return new IfcSpecularRoughness{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcSpecularRoughness obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTemperatureGradientMeasure : REAL
	{
		public IfcTemperatureGradientMeasure(){}

		{
			return new IfcTemperatureGradientMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcTemperatureGradientMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTemperatureRateOfChangeMeasure : REAL
	{
		public IfcTemperatureRateOfChangeMeasure(){}

		{
			return new IfcTemperatureRateOfChangeMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcTemperatureRateOfChangeMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcText : STRING
	{
		public IfcText(){}

		{
			return new IfcText{ Value = value };
		}
		public static implicit operator string(IfcText obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTextAlignment : STRING
	{
		public IfcTextAlignment(){}

		{
			return new IfcTextAlignment{ Value = value };
		}
		public static implicit operator string(IfcTextAlignment obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTextDecoration : STRING
	{
		public IfcTextDecoration(){}

		{
			return new IfcTextDecoration{ Value = value };
		}
		public static implicit operator string(IfcTextDecoration obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTextFontName : STRING
	{
		public IfcTextFontName(){}

		{
			return new IfcTextFontName{ Value = value };
		}
		public static implicit operator string(IfcTextFontName obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTextTransformation : STRING
	{
		public IfcTextTransformation(){}

		{
			return new IfcTextTransformation{ Value = value };
		}
		public static implicit operator string(IfcTextTransformation obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalAdmittanceMeasure : REAL
	{
		public IfcThermalAdmittanceMeasure(){}

		{
			return new IfcThermalAdmittanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalAdmittanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalConductivityMeasure : REAL
	{
		public IfcThermalConductivityMeasure(){}

		{
			return new IfcThermalConductivityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalConductivityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalExpansionCoefficientMeasure : REAL
	{
		public IfcThermalExpansionCoefficientMeasure(){}

		{
			return new IfcThermalExpansionCoefficientMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalExpansionCoefficientMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalResistanceMeasure : REAL
	{
		public IfcThermalResistanceMeasure(){}

		{
			return new IfcThermalResistanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalResistanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermalTransmittanceMeasure : REAL
	{
		public IfcThermalTransmittanceMeasure(){}

		{
			return new IfcThermalTransmittanceMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermalTransmittanceMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcThermodynamicTemperatureMeasure : REAL
	{
		public IfcThermodynamicTemperatureMeasure(){}

		{
			return new IfcThermodynamicTemperatureMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcThermodynamicTemperatureMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTime : STRING
	{
		public IfcTime(){}

		{
			return new IfcTime{ Value = value };
		}
		public static implicit operator string(IfcTime obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTimeMeasure : REAL
	{
		public IfcTimeMeasure(){}

		{
			return new IfcTimeMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcTimeMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTimeStamp : INTEGER
	{
		public IfcTimeStamp(){}

		{
			return new IfcTimeStamp{ Value = value };
		}
		public static implicit operator int(IfcTimeStamp obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcTorqueMeasure : REAL
	{
		public IfcTorqueMeasure(){}

		{
			return new IfcTorqueMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcTorqueMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcURIReference : STRING
	{
		public IfcURIReference(){}

		{
			return new IfcURIReference{ Value = value };
		}
		public static implicit operator string(IfcURIReference obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcVaporPermeabilityMeasure : REAL
	{
		public IfcVaporPermeabilityMeasure(){}

		{
			return new IfcVaporPermeabilityMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcVaporPermeabilityMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcVolumeMeasure : REAL
	{
		public IfcVolumeMeasure(){}

		{
			return new IfcVolumeMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcVolumeMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcVolumetricFlowRateMeasure : REAL
	{
		public IfcVolumetricFlowRateMeasure(){}

		{
			return new IfcVolumetricFlowRateMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcVolumetricFlowRateMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcWarpingConstantMeasure : REAL
	{
		public IfcWarpingConstantMeasure(){}

		{
			return new IfcWarpingConstantMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcWarpingConstantMeasure obj)
		{
			return obj.Value;
		}
	}

	public partial class IfcWarpingMomentMeasure : REAL
	{
		public IfcWarpingMomentMeasure(){}

		{
			return new IfcWarpingMomentMeasure{ Value = Math.Round(value, Precision) };
		}
		public static implicit operator double(IfcWarpingMomentMeasure obj)
		{
			return obj.Value;
		}
	}

	public class IfcActionRequestTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcActionRequestTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcActionRequestTypeEnum EMAIL = new IfcActionRequestTypeEnum( "EMAIL" );
		public static readonly IfcActionRequestTypeEnum FAX = new IfcActionRequestTypeEnum( "FAX" );
		public static readonly IfcActionRequestTypeEnum PHONE = new IfcActionRequestTypeEnum( "PHONE" );
		public static readonly IfcActionRequestTypeEnum POST = new IfcActionRequestTypeEnum( "POST" );
		public static readonly IfcActionRequestTypeEnum VERBAL = new IfcActionRequestTypeEnum( "VERBAL" );
		public static readonly IfcActionRequestTypeEnum USERDEFINED = new IfcActionRequestTypeEnum( "USERDEFINED" );
		public static readonly IfcActionRequestTypeEnum NOTDEFINED = new IfcActionRequestTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcActionSourceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcActionSourceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcActionSourceTypeEnum DEAD_LOAD_G = new IfcActionSourceTypeEnum( "DEAD_LOAD_G" );
		public static readonly IfcActionSourceTypeEnum COMPLETION_G1 = new IfcActionSourceTypeEnum( "COMPLETION_G1" );
		public static readonly IfcActionSourceTypeEnum LIVE_LOAD_Q = new IfcActionSourceTypeEnum( "LIVE_LOAD_Q" );
		public static readonly IfcActionSourceTypeEnum SNOW_S = new IfcActionSourceTypeEnum( "SNOW_S" );
		public static readonly IfcActionSourceTypeEnum WIND_W = new IfcActionSourceTypeEnum( "WIND_W" );
		public static readonly IfcActionSourceTypeEnum PRESTRESSING_P = new IfcActionSourceTypeEnum( "PRESTRESSING_P" );
		public static readonly IfcActionSourceTypeEnum SETTLEMENT_U = new IfcActionSourceTypeEnum( "SETTLEMENT_U" );
		public static readonly IfcActionSourceTypeEnum TEMPERATURE_T = new IfcActionSourceTypeEnum( "TEMPERATURE_T" );
		public static readonly IfcActionSourceTypeEnum EARTHQUAKE_E = new IfcActionSourceTypeEnum( "EARTHQUAKE_E" );
		public static readonly IfcActionSourceTypeEnum FIRE = new IfcActionSourceTypeEnum( "FIRE" );
		public static readonly IfcActionSourceTypeEnum IMPULSE = new IfcActionSourceTypeEnum( "IMPULSE" );
		public static readonly IfcActionSourceTypeEnum IMPACT = new IfcActionSourceTypeEnum( "IMPACT" );
		public static readonly IfcActionSourceTypeEnum TRANSPORT = new IfcActionSourceTypeEnum( "TRANSPORT" );
		public static readonly IfcActionSourceTypeEnum ERECTION = new IfcActionSourceTypeEnum( "ERECTION" );
		public static readonly IfcActionSourceTypeEnum PROPPING = new IfcActionSourceTypeEnum( "PROPPING" );
		public static readonly IfcActionSourceTypeEnum SYSTEM_IMPERFECTION = new IfcActionSourceTypeEnum( "SYSTEM_IMPERFECTION" );
		public static readonly IfcActionSourceTypeEnum SHRINKAGE = new IfcActionSourceTypeEnum( "SHRINKAGE" );
		public static readonly IfcActionSourceTypeEnum CREEP = new IfcActionSourceTypeEnum( "CREEP" );
		public static readonly IfcActionSourceTypeEnum LACK_OF_FIT = new IfcActionSourceTypeEnum( "LACK_OF_FIT" );
		public static readonly IfcActionSourceTypeEnum BUOYANCY = new IfcActionSourceTypeEnum( "BUOYANCY" );
		public static readonly IfcActionSourceTypeEnum ICE = new IfcActionSourceTypeEnum( "ICE" );
		public static readonly IfcActionSourceTypeEnum CURRENT = new IfcActionSourceTypeEnum( "CURRENT" );
		public static readonly IfcActionSourceTypeEnum WAVE = new IfcActionSourceTypeEnum( "WAVE" );
		public static readonly IfcActionSourceTypeEnum RAIN = new IfcActionSourceTypeEnum( "RAIN" );
		public static readonly IfcActionSourceTypeEnum BRAKES = new IfcActionSourceTypeEnum( "BRAKES" );
		public static readonly IfcActionSourceTypeEnum USERDEFINED = new IfcActionSourceTypeEnum( "USERDEFINED" );
		public static readonly IfcActionSourceTypeEnum NOTDEFINED = new IfcActionSourceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcActionTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcActionTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcActionTypeEnum PERMANENT_G = new IfcActionTypeEnum( "PERMANENT_G" );
		public static readonly IfcActionTypeEnum VARIABLE_Q = new IfcActionTypeEnum( "VARIABLE_Q" );
		public static readonly IfcActionTypeEnum EXTRAORDINARY_A = new IfcActionTypeEnum( "EXTRAORDINARY_A" );
		public static readonly IfcActionTypeEnum USERDEFINED = new IfcActionTypeEnum( "USERDEFINED" );
		public static readonly IfcActionTypeEnum NOTDEFINED = new IfcActionTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcActuatorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcActuatorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcActuatorTypeEnum ELECTRICACTUATOR = new IfcActuatorTypeEnum( "ELECTRICACTUATOR" );
		public static readonly IfcActuatorTypeEnum HANDOPERATEDACTUATOR = new IfcActuatorTypeEnum( "HANDOPERATEDACTUATOR" );
		public static readonly IfcActuatorTypeEnum HYDRAULICACTUATOR = new IfcActuatorTypeEnum( "HYDRAULICACTUATOR" );
		public static readonly IfcActuatorTypeEnum PNEUMATICACTUATOR = new IfcActuatorTypeEnum( "PNEUMATICACTUATOR" );
		public static readonly IfcActuatorTypeEnum THERMOSTATICACTUATOR = new IfcActuatorTypeEnum( "THERMOSTATICACTUATOR" );
		public static readonly IfcActuatorTypeEnum USERDEFINED = new IfcActuatorTypeEnum( "USERDEFINED" );
		public static readonly IfcActuatorTypeEnum NOTDEFINED = new IfcActuatorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAddressTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAddressTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAddressTypeEnum OFFICE = new IfcAddressTypeEnum( "OFFICE" );
		public static readonly IfcAddressTypeEnum SITE = new IfcAddressTypeEnum( "SITE" );
		public static readonly IfcAddressTypeEnum HOME = new IfcAddressTypeEnum( "HOME" );
		public static readonly IfcAddressTypeEnum DISTRIBUTIONPOINT = new IfcAddressTypeEnum( "DISTRIBUTIONPOINT" );
		public static readonly IfcAddressTypeEnum USERDEFINED = new IfcAddressTypeEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAirTerminalBoxTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAirTerminalBoxTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAirTerminalBoxTypeEnum CONSTANTFLOW = new IfcAirTerminalBoxTypeEnum( "CONSTANTFLOW" );
		public static readonly IfcAirTerminalBoxTypeEnum VARIABLEFLOWPRESSUREDEPENDANT = new IfcAirTerminalBoxTypeEnum( "VARIABLEFLOWPRESSUREDEPENDANT" );
		public static readonly IfcAirTerminalBoxTypeEnum VARIABLEFLOWPRESSUREINDEPENDANT = new IfcAirTerminalBoxTypeEnum( "VARIABLEFLOWPRESSUREINDEPENDANT" );
		public static readonly IfcAirTerminalBoxTypeEnum USERDEFINED = new IfcAirTerminalBoxTypeEnum( "USERDEFINED" );
		public static readonly IfcAirTerminalBoxTypeEnum NOTDEFINED = new IfcAirTerminalBoxTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAirTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAirTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAirTerminalTypeEnum DIFFUSER = new IfcAirTerminalTypeEnum( "DIFFUSER" );
		public static readonly IfcAirTerminalTypeEnum GRILLE = new IfcAirTerminalTypeEnum( "GRILLE" );
		public static readonly IfcAirTerminalTypeEnum LOUVRE = new IfcAirTerminalTypeEnum( "LOUVRE" );
		public static readonly IfcAirTerminalTypeEnum REGISTER = new IfcAirTerminalTypeEnum( "REGISTER" );
		public static readonly IfcAirTerminalTypeEnum USERDEFINED = new IfcAirTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcAirTerminalTypeEnum NOTDEFINED = new IfcAirTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAirToAirHeatRecoveryTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAirToAirHeatRecoveryTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAirToAirHeatRecoveryTypeEnum FIXEDPLATECOUNTERFLOWEXCHANGER = new IfcAirToAirHeatRecoveryTypeEnum( "FIXEDPLATECOUNTERFLOWEXCHANGER" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum FIXEDPLATECROSSFLOWEXCHANGER = new IfcAirToAirHeatRecoveryTypeEnum( "FIXEDPLATECROSSFLOWEXCHANGER" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum FIXEDPLATEPARALLELFLOWEXCHANGER = new IfcAirToAirHeatRecoveryTypeEnum( "FIXEDPLATEPARALLELFLOWEXCHANGER" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum ROTARYWHEEL = new IfcAirToAirHeatRecoveryTypeEnum( "ROTARYWHEEL" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum RUNAROUNDCOILLOOP = new IfcAirToAirHeatRecoveryTypeEnum( "RUNAROUNDCOILLOOP" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum HEATPIPE = new IfcAirToAirHeatRecoveryTypeEnum( "HEATPIPE" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum TWINTOWERENTHALPYRECOVERYLOOPS = new IfcAirToAirHeatRecoveryTypeEnum( "TWINTOWERENTHALPYRECOVERYLOOPS" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum THERMOSIPHONSEALEDTUBEHEATEXCHANGERS = new IfcAirToAirHeatRecoveryTypeEnum( "THERMOSIPHONSEALEDTUBEHEATEXCHANGERS" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum THERMOSIPHONCOILTYPEHEATEXCHANGERS = new IfcAirToAirHeatRecoveryTypeEnum( "THERMOSIPHONCOILTYPEHEATEXCHANGERS" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum USERDEFINED = new IfcAirToAirHeatRecoveryTypeEnum( "USERDEFINED" );
		public static readonly IfcAirToAirHeatRecoveryTypeEnum NOTDEFINED = new IfcAirToAirHeatRecoveryTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAlarmTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAlarmTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAlarmTypeEnum BELL = new IfcAlarmTypeEnum( "BELL" );
		public static readonly IfcAlarmTypeEnum BREAKGLASSBUTTON = new IfcAlarmTypeEnum( "BREAKGLASSBUTTON" );
		public static readonly IfcAlarmTypeEnum LIGHT = new IfcAlarmTypeEnum( "LIGHT" );
		public static readonly IfcAlarmTypeEnum MANUALPULLBOX = new IfcAlarmTypeEnum( "MANUALPULLBOX" );
		public static readonly IfcAlarmTypeEnum SIREN = new IfcAlarmTypeEnum( "SIREN" );
		public static readonly IfcAlarmTypeEnum WHISTLE = new IfcAlarmTypeEnum( "WHISTLE" );
		public static readonly IfcAlarmTypeEnum USERDEFINED = new IfcAlarmTypeEnum( "USERDEFINED" );
		public static readonly IfcAlarmTypeEnum NOTDEFINED = new IfcAlarmTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAnalysisModelTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAnalysisModelTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAnalysisModelTypeEnum IN_PLANE_LOADING_2D = new IfcAnalysisModelTypeEnum( "IN_PLANE_LOADING_2D" );
		public static readonly IfcAnalysisModelTypeEnum OUT_PLANE_LOADING_2D = new IfcAnalysisModelTypeEnum( "OUT_PLANE_LOADING_2D" );
		public static readonly IfcAnalysisModelTypeEnum LOADING_3D = new IfcAnalysisModelTypeEnum( "LOADING_3D" );
		public static readonly IfcAnalysisModelTypeEnum USERDEFINED = new IfcAnalysisModelTypeEnum( "USERDEFINED" );
		public static readonly IfcAnalysisModelTypeEnum NOTDEFINED = new IfcAnalysisModelTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAnalysisTheoryTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAnalysisTheoryTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAnalysisTheoryTypeEnum FIRST_ORDER_THEORY = new IfcAnalysisTheoryTypeEnum( "FIRST_ORDER_THEORY" );
		public static readonly IfcAnalysisTheoryTypeEnum SECOND_ORDER_THEORY = new IfcAnalysisTheoryTypeEnum( "SECOND_ORDER_THEORY" );
		public static readonly IfcAnalysisTheoryTypeEnum THIRD_ORDER_THEORY = new IfcAnalysisTheoryTypeEnum( "THIRD_ORDER_THEORY" );
		public static readonly IfcAnalysisTheoryTypeEnum FULL_NONLINEAR_THEORY = new IfcAnalysisTheoryTypeEnum( "FULL_NONLINEAR_THEORY" );
		public static readonly IfcAnalysisTheoryTypeEnum USERDEFINED = new IfcAnalysisTheoryTypeEnum( "USERDEFINED" );
		public static readonly IfcAnalysisTheoryTypeEnum NOTDEFINED = new IfcAnalysisTheoryTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcArithmeticOperatorEnum : BaseType
	{
	private readonly string ename;
		private IfcArithmeticOperatorEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcArithmeticOperatorEnum ADD = new IfcArithmeticOperatorEnum( "ADD" );
		public static readonly IfcArithmeticOperatorEnum DIVIDE = new IfcArithmeticOperatorEnum( "DIVIDE" );
		public static readonly IfcArithmeticOperatorEnum MULTIPLY = new IfcArithmeticOperatorEnum( "MULTIPLY" );
		public static readonly IfcArithmeticOperatorEnum SUBTRACT = new IfcArithmeticOperatorEnum( "SUBTRACT" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAssemblyPlaceEnum : BaseType
	{
	private readonly string ename;
		private IfcAssemblyPlaceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAssemblyPlaceEnum SITE = new IfcAssemblyPlaceEnum( "SITE" );
		public static readonly IfcAssemblyPlaceEnum FACTORY = new IfcAssemblyPlaceEnum( "FACTORY" );
		public static readonly IfcAssemblyPlaceEnum NOTDEFINED = new IfcAssemblyPlaceEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcAudioVisualApplianceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcAudioVisualApplianceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcAudioVisualApplianceTypeEnum AMPLIFIER = new IfcAudioVisualApplianceTypeEnum( "AMPLIFIER" );
		public static readonly IfcAudioVisualApplianceTypeEnum CAMERA = new IfcAudioVisualApplianceTypeEnum( "CAMERA" );
		public static readonly IfcAudioVisualApplianceTypeEnum DISPLAY = new IfcAudioVisualApplianceTypeEnum( "DISPLAY" );
		public static readonly IfcAudioVisualApplianceTypeEnum MICROPHONE = new IfcAudioVisualApplianceTypeEnum( "MICROPHONE" );
		public static readonly IfcAudioVisualApplianceTypeEnum PLAYER = new IfcAudioVisualApplianceTypeEnum( "PLAYER" );
		public static readonly IfcAudioVisualApplianceTypeEnum PROJECTOR = new IfcAudioVisualApplianceTypeEnum( "PROJECTOR" );
		public static readonly IfcAudioVisualApplianceTypeEnum RECEIVER = new IfcAudioVisualApplianceTypeEnum( "RECEIVER" );
		public static readonly IfcAudioVisualApplianceTypeEnum SPEAKER = new IfcAudioVisualApplianceTypeEnum( "SPEAKER" );
		public static readonly IfcAudioVisualApplianceTypeEnum SWITCHER = new IfcAudioVisualApplianceTypeEnum( "SWITCHER" );
		public static readonly IfcAudioVisualApplianceTypeEnum TELEPHONE = new IfcAudioVisualApplianceTypeEnum( "TELEPHONE" );
		public static readonly IfcAudioVisualApplianceTypeEnum TUNER = new IfcAudioVisualApplianceTypeEnum( "TUNER" );
		public static readonly IfcAudioVisualApplianceTypeEnum USERDEFINED = new IfcAudioVisualApplianceTypeEnum( "USERDEFINED" );
		public static readonly IfcAudioVisualApplianceTypeEnum NOTDEFINED = new IfcAudioVisualApplianceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBSplineCurveForm : BaseType
	{
	private readonly string ename;
		private IfcBSplineCurveForm (string enumName)
		{ ename = enumName; }
		public static readonly IfcBSplineCurveForm POLYLINE_FORM = new IfcBSplineCurveForm( "POLYLINE_FORM" );
		public static readonly IfcBSplineCurveForm CIRCULAR_ARC = new IfcBSplineCurveForm( "CIRCULAR_ARC" );
		public static readonly IfcBSplineCurveForm ELLIPTIC_ARC = new IfcBSplineCurveForm( "ELLIPTIC_ARC" );
		public static readonly IfcBSplineCurveForm PARABOLIC_ARC = new IfcBSplineCurveForm( "PARABOLIC_ARC" );
		public static readonly IfcBSplineCurveForm HYPERBOLIC_ARC = new IfcBSplineCurveForm( "HYPERBOLIC_ARC" );
		public static readonly IfcBSplineCurveForm UNSPECIFIED = new IfcBSplineCurveForm( "UNSPECIFIED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBSplineSurfaceForm : BaseType
	{
	private readonly string ename;
		private IfcBSplineSurfaceForm (string enumName)
		{ ename = enumName; }
		public static readonly IfcBSplineSurfaceForm PLANE_SURF = new IfcBSplineSurfaceForm( "PLANE_SURF" );
		public static readonly IfcBSplineSurfaceForm CYLINDRICAL_SURF = new IfcBSplineSurfaceForm( "CYLINDRICAL_SURF" );
		public static readonly IfcBSplineSurfaceForm CONICAL_SURF = new IfcBSplineSurfaceForm( "CONICAL_SURF" );
		public static readonly IfcBSplineSurfaceForm SPHERICAL_SURF = new IfcBSplineSurfaceForm( "SPHERICAL_SURF" );
		public static readonly IfcBSplineSurfaceForm TOROIDAL_SURF = new IfcBSplineSurfaceForm( "TOROIDAL_SURF" );
		public static readonly IfcBSplineSurfaceForm SURF_OF_REVOLUTION = new IfcBSplineSurfaceForm( "SURF_OF_REVOLUTION" );
		public static readonly IfcBSplineSurfaceForm RULED_SURF = new IfcBSplineSurfaceForm( "RULED_SURF" );
		public static readonly IfcBSplineSurfaceForm GENERALISED_CONE = new IfcBSplineSurfaceForm( "GENERALISED_CONE" );
		public static readonly IfcBSplineSurfaceForm QUADRIC_SURF = new IfcBSplineSurfaceForm( "QUADRIC_SURF" );
		public static readonly IfcBSplineSurfaceForm SURF_OF_LINEAR_EXTRUSION = new IfcBSplineSurfaceForm( "SURF_OF_LINEAR_EXTRUSION" );
		public static readonly IfcBSplineSurfaceForm UNSPECIFIED = new IfcBSplineSurfaceForm( "UNSPECIFIED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBeamTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBeamTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBeamTypeEnum BEAM = new IfcBeamTypeEnum( "BEAM" );
		public static readonly IfcBeamTypeEnum JOIST = new IfcBeamTypeEnum( "JOIST" );
		public static readonly IfcBeamTypeEnum HOLLOWCORE = new IfcBeamTypeEnum( "HOLLOWCORE" );
		public static readonly IfcBeamTypeEnum LINTEL = new IfcBeamTypeEnum( "LINTEL" );
		public static readonly IfcBeamTypeEnum SPANDREL = new IfcBeamTypeEnum( "SPANDREL" );
		public static readonly IfcBeamTypeEnum T_BEAM = new IfcBeamTypeEnum( "T_BEAM" );
		public static readonly IfcBeamTypeEnum USERDEFINED = new IfcBeamTypeEnum( "USERDEFINED" );
		public static readonly IfcBeamTypeEnum NOTDEFINED = new IfcBeamTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBenchmarkEnum : BaseType
	{
	private readonly string ename;
		private IfcBenchmarkEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBenchmarkEnum GREATERTHAN = new IfcBenchmarkEnum( "GREATERTHAN" );
		public static readonly IfcBenchmarkEnum GREATERTHANOREQUALTO = new IfcBenchmarkEnum( "GREATERTHANOREQUALTO" );
		public static readonly IfcBenchmarkEnum LESSTHAN = new IfcBenchmarkEnum( "LESSTHAN" );
		public static readonly IfcBenchmarkEnum LESSTHANOREQUALTO = new IfcBenchmarkEnum( "LESSTHANOREQUALTO" );
		public static readonly IfcBenchmarkEnum EQUALTO = new IfcBenchmarkEnum( "EQUALTO" );
		public static readonly IfcBenchmarkEnum NOTEQUALTO = new IfcBenchmarkEnum( "NOTEQUALTO" );
		public static readonly IfcBenchmarkEnum INCLUDES = new IfcBenchmarkEnum( "INCLUDES" );
		public static readonly IfcBenchmarkEnum NOTINCLUDES = new IfcBenchmarkEnum( "NOTINCLUDES" );
		public static readonly IfcBenchmarkEnum INCLUDEDIN = new IfcBenchmarkEnum( "INCLUDEDIN" );
		public static readonly IfcBenchmarkEnum NOTINCLUDEDIN = new IfcBenchmarkEnum( "NOTINCLUDEDIN" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBoilerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBoilerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBoilerTypeEnum WATER = new IfcBoilerTypeEnum( "WATER" );
		public static readonly IfcBoilerTypeEnum STEAM = new IfcBoilerTypeEnum( "STEAM" );
		public static readonly IfcBoilerTypeEnum USERDEFINED = new IfcBoilerTypeEnum( "USERDEFINED" );
		public static readonly IfcBoilerTypeEnum NOTDEFINED = new IfcBoilerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBooleanOperator : BaseType
	{
	private readonly string ename;
		private IfcBooleanOperator (string enumName)
		{ ename = enumName; }
		public static readonly IfcBooleanOperator UNION = new IfcBooleanOperator( "UNION" );
		public static readonly IfcBooleanOperator INTERSECTION = new IfcBooleanOperator( "INTERSECTION" );
		public static readonly IfcBooleanOperator DIFFERENCE = new IfcBooleanOperator( "DIFFERENCE" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBuildingElementPartTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBuildingElementPartTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBuildingElementPartTypeEnum INSULATION = new IfcBuildingElementPartTypeEnum( "INSULATION" );
		public static readonly IfcBuildingElementPartTypeEnum PRECASTPANEL = new IfcBuildingElementPartTypeEnum( "PRECASTPANEL" );
		public static readonly IfcBuildingElementPartTypeEnum USERDEFINED = new IfcBuildingElementPartTypeEnum( "USERDEFINED" );
		public static readonly IfcBuildingElementPartTypeEnum NOTDEFINED = new IfcBuildingElementPartTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBuildingElementProxyTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBuildingElementProxyTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBuildingElementProxyTypeEnum COMPLEX = new IfcBuildingElementProxyTypeEnum( "COMPLEX" );
		public static readonly IfcBuildingElementProxyTypeEnum ELEMENT = new IfcBuildingElementProxyTypeEnum( "ELEMENT" );
		public static readonly IfcBuildingElementProxyTypeEnum PARTIAL = new IfcBuildingElementProxyTypeEnum( "PARTIAL" );
		public static readonly IfcBuildingElementProxyTypeEnum PROVISIONFORVOID = new IfcBuildingElementProxyTypeEnum( "PROVISIONFORVOID" );
		public static readonly IfcBuildingElementProxyTypeEnum USERDEFINED = new IfcBuildingElementProxyTypeEnum( "USERDEFINED" );
		public static readonly IfcBuildingElementProxyTypeEnum NOTDEFINED = new IfcBuildingElementProxyTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBuildingSystemTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBuildingSystemTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBuildingSystemTypeEnum FENESTRATION = new IfcBuildingSystemTypeEnum( "FENESTRATION" );
		public static readonly IfcBuildingSystemTypeEnum FOUNDATION = new IfcBuildingSystemTypeEnum( "FOUNDATION" );
		public static readonly IfcBuildingSystemTypeEnum LOADBEARING = new IfcBuildingSystemTypeEnum( "LOADBEARING" );
		public static readonly IfcBuildingSystemTypeEnum OUTERSHELL = new IfcBuildingSystemTypeEnum( "OUTERSHELL" );
		public static readonly IfcBuildingSystemTypeEnum SHADING = new IfcBuildingSystemTypeEnum( "SHADING" );
		public static readonly IfcBuildingSystemTypeEnum TRANSPORT = new IfcBuildingSystemTypeEnum( "TRANSPORT" );
		public static readonly IfcBuildingSystemTypeEnum USERDEFINED = new IfcBuildingSystemTypeEnum( "USERDEFINED" );
		public static readonly IfcBuildingSystemTypeEnum NOTDEFINED = new IfcBuildingSystemTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcBurnerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcBurnerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcBurnerTypeEnum USERDEFINED = new IfcBurnerTypeEnum( "USERDEFINED" );
		public static readonly IfcBurnerTypeEnum NOTDEFINED = new IfcBurnerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCableCarrierFittingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCableCarrierFittingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCableCarrierFittingTypeEnum BEND = new IfcCableCarrierFittingTypeEnum( "BEND" );
		public static readonly IfcCableCarrierFittingTypeEnum CROSS = new IfcCableCarrierFittingTypeEnum( "CROSS" );
		public static readonly IfcCableCarrierFittingTypeEnum REDUCER = new IfcCableCarrierFittingTypeEnum( "REDUCER" );
		public static readonly IfcCableCarrierFittingTypeEnum TEE = new IfcCableCarrierFittingTypeEnum( "TEE" );
		public static readonly IfcCableCarrierFittingTypeEnum USERDEFINED = new IfcCableCarrierFittingTypeEnum( "USERDEFINED" );
		public static readonly IfcCableCarrierFittingTypeEnum NOTDEFINED = new IfcCableCarrierFittingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCableCarrierSegmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCableCarrierSegmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCableCarrierSegmentTypeEnum CABLELADDERSEGMENT = new IfcCableCarrierSegmentTypeEnum( "CABLELADDERSEGMENT" );
		public static readonly IfcCableCarrierSegmentTypeEnum CABLETRAYSEGMENT = new IfcCableCarrierSegmentTypeEnum( "CABLETRAYSEGMENT" );
		public static readonly IfcCableCarrierSegmentTypeEnum CABLETRUNKINGSEGMENT = new IfcCableCarrierSegmentTypeEnum( "CABLETRUNKINGSEGMENT" );
		public static readonly IfcCableCarrierSegmentTypeEnum CONDUITSEGMENT = new IfcCableCarrierSegmentTypeEnum( "CONDUITSEGMENT" );
		public static readonly IfcCableCarrierSegmentTypeEnum USERDEFINED = new IfcCableCarrierSegmentTypeEnum( "USERDEFINED" );
		public static readonly IfcCableCarrierSegmentTypeEnum NOTDEFINED = new IfcCableCarrierSegmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCableFittingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCableFittingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCableFittingTypeEnum CONNECTOR = new IfcCableFittingTypeEnum( "CONNECTOR" );
		public static readonly IfcCableFittingTypeEnum ENTRY = new IfcCableFittingTypeEnum( "ENTRY" );
		public static readonly IfcCableFittingTypeEnum EXIT = new IfcCableFittingTypeEnum( "EXIT" );
		public static readonly IfcCableFittingTypeEnum JUNCTION = new IfcCableFittingTypeEnum( "JUNCTION" );
		public static readonly IfcCableFittingTypeEnum TRANSITION = new IfcCableFittingTypeEnum( "TRANSITION" );
		public static readonly IfcCableFittingTypeEnum USERDEFINED = new IfcCableFittingTypeEnum( "USERDEFINED" );
		public static readonly IfcCableFittingTypeEnum NOTDEFINED = new IfcCableFittingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCableSegmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCableSegmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCableSegmentTypeEnum BUSBARSEGMENT = new IfcCableSegmentTypeEnum( "BUSBARSEGMENT" );
		public static readonly IfcCableSegmentTypeEnum CABLESEGMENT = new IfcCableSegmentTypeEnum( "CABLESEGMENT" );
		public static readonly IfcCableSegmentTypeEnum CONDUCTORSEGMENT = new IfcCableSegmentTypeEnum( "CONDUCTORSEGMENT" );
		public static readonly IfcCableSegmentTypeEnum CORESEGMENT = new IfcCableSegmentTypeEnum( "CORESEGMENT" );
		public static readonly IfcCableSegmentTypeEnum USERDEFINED = new IfcCableSegmentTypeEnum( "USERDEFINED" );
		public static readonly IfcCableSegmentTypeEnum NOTDEFINED = new IfcCableSegmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcChangeActionEnum : BaseType
	{
	private readonly string ename;
		private IfcChangeActionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcChangeActionEnum NOCHANGE = new IfcChangeActionEnum( "NOCHANGE" );
		public static readonly IfcChangeActionEnum MODIFIED = new IfcChangeActionEnum( "MODIFIED" );
		public static readonly IfcChangeActionEnum ADDED = new IfcChangeActionEnum( "ADDED" );
		public static readonly IfcChangeActionEnum DELETED = new IfcChangeActionEnum( "DELETED" );
		public static readonly IfcChangeActionEnum NOTDEFINED = new IfcChangeActionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcChillerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcChillerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcChillerTypeEnum AIRCOOLED = new IfcChillerTypeEnum( "AIRCOOLED" );
		public static readonly IfcChillerTypeEnum WATERCOOLED = new IfcChillerTypeEnum( "WATERCOOLED" );
		public static readonly IfcChillerTypeEnum HEATRECOVERY = new IfcChillerTypeEnum( "HEATRECOVERY" );
		public static readonly IfcChillerTypeEnum USERDEFINED = new IfcChillerTypeEnum( "USERDEFINED" );
		public static readonly IfcChillerTypeEnum NOTDEFINED = new IfcChillerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcChimneyTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcChimneyTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcChimneyTypeEnum USERDEFINED = new IfcChimneyTypeEnum( "USERDEFINED" );
		public static readonly IfcChimneyTypeEnum NOTDEFINED = new IfcChimneyTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCoilTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCoilTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCoilTypeEnum DXCOOLINGCOIL = new IfcCoilTypeEnum( "DXCOOLINGCOIL" );
		public static readonly IfcCoilTypeEnum ELECTRICHEATINGCOIL = new IfcCoilTypeEnum( "ELECTRICHEATINGCOIL" );
		public static readonly IfcCoilTypeEnum GASHEATINGCOIL = new IfcCoilTypeEnum( "GASHEATINGCOIL" );
		public static readonly IfcCoilTypeEnum HYDRONICCOIL = new IfcCoilTypeEnum( "HYDRONICCOIL" );
		public static readonly IfcCoilTypeEnum STEAMHEATINGCOIL = new IfcCoilTypeEnum( "STEAMHEATINGCOIL" );
		public static readonly IfcCoilTypeEnum WATERCOOLINGCOIL = new IfcCoilTypeEnum( "WATERCOOLINGCOIL" );
		public static readonly IfcCoilTypeEnum WATERHEATINGCOIL = new IfcCoilTypeEnum( "WATERHEATINGCOIL" );
		public static readonly IfcCoilTypeEnum USERDEFINED = new IfcCoilTypeEnum( "USERDEFINED" );
		public static readonly IfcCoilTypeEnum NOTDEFINED = new IfcCoilTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcColumnTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcColumnTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcColumnTypeEnum COLUMN = new IfcColumnTypeEnum( "COLUMN" );
		public static readonly IfcColumnTypeEnum PILASTER = new IfcColumnTypeEnum( "PILASTER" );
		public static readonly IfcColumnTypeEnum USERDEFINED = new IfcColumnTypeEnum( "USERDEFINED" );
		public static readonly IfcColumnTypeEnum NOTDEFINED = new IfcColumnTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCommunicationsApplianceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCommunicationsApplianceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCommunicationsApplianceTypeEnum ANTENNA = new IfcCommunicationsApplianceTypeEnum( "ANTENNA" );
		public static readonly IfcCommunicationsApplianceTypeEnum COMPUTER = new IfcCommunicationsApplianceTypeEnum( "COMPUTER" );
		public static readonly IfcCommunicationsApplianceTypeEnum FAX = new IfcCommunicationsApplianceTypeEnum( "FAX" );
		public static readonly IfcCommunicationsApplianceTypeEnum GATEWAY = new IfcCommunicationsApplianceTypeEnum( "GATEWAY" );
		public static readonly IfcCommunicationsApplianceTypeEnum MODEM = new IfcCommunicationsApplianceTypeEnum( "MODEM" );
		public static readonly IfcCommunicationsApplianceTypeEnum NETWORKAPPLIANCE = new IfcCommunicationsApplianceTypeEnum( "NETWORKAPPLIANCE" );
		public static readonly IfcCommunicationsApplianceTypeEnum NETWORKBRIDGE = new IfcCommunicationsApplianceTypeEnum( "NETWORKBRIDGE" );
		public static readonly IfcCommunicationsApplianceTypeEnum NETWORKHUB = new IfcCommunicationsApplianceTypeEnum( "NETWORKHUB" );
		public static readonly IfcCommunicationsApplianceTypeEnum PRINTER = new IfcCommunicationsApplianceTypeEnum( "PRINTER" );
		public static readonly IfcCommunicationsApplianceTypeEnum REPEATER = new IfcCommunicationsApplianceTypeEnum( "REPEATER" );
		public static readonly IfcCommunicationsApplianceTypeEnum ROUTER = new IfcCommunicationsApplianceTypeEnum( "ROUTER" );
		public static readonly IfcCommunicationsApplianceTypeEnum SCANNER = new IfcCommunicationsApplianceTypeEnum( "SCANNER" );
		public static readonly IfcCommunicationsApplianceTypeEnum USERDEFINED = new IfcCommunicationsApplianceTypeEnum( "USERDEFINED" );
		public static readonly IfcCommunicationsApplianceTypeEnum NOTDEFINED = new IfcCommunicationsApplianceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcComplexPropertyTemplateTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcComplexPropertyTemplateTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcComplexPropertyTemplateTypeEnum P_COMPLEX = new IfcComplexPropertyTemplateTypeEnum( "P_COMPLEX" );
		public static readonly IfcComplexPropertyTemplateTypeEnum Q_COMPLEX = new IfcComplexPropertyTemplateTypeEnum( "Q_COMPLEX" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCompressorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCompressorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCompressorTypeEnum DYNAMIC = new IfcCompressorTypeEnum( "DYNAMIC" );
		public static readonly IfcCompressorTypeEnum RECIPROCATING = new IfcCompressorTypeEnum( "RECIPROCATING" );
		public static readonly IfcCompressorTypeEnum ROTARY = new IfcCompressorTypeEnum( "ROTARY" );
		public static readonly IfcCompressorTypeEnum SCROLL = new IfcCompressorTypeEnum( "SCROLL" );
		public static readonly IfcCompressorTypeEnum TROCHOIDAL = new IfcCompressorTypeEnum( "TROCHOIDAL" );
		public static readonly IfcCompressorTypeEnum SINGLESTAGE = new IfcCompressorTypeEnum( "SINGLESTAGE" );
		public static readonly IfcCompressorTypeEnum BOOSTER = new IfcCompressorTypeEnum( "BOOSTER" );
		public static readonly IfcCompressorTypeEnum OPENTYPE = new IfcCompressorTypeEnum( "OPENTYPE" );
		public static readonly IfcCompressorTypeEnum HERMETIC = new IfcCompressorTypeEnum( "HERMETIC" );
		public static readonly IfcCompressorTypeEnum SEMIHERMETIC = new IfcCompressorTypeEnum( "SEMIHERMETIC" );
		public static readonly IfcCompressorTypeEnum WELDEDSHELLHERMETIC = new IfcCompressorTypeEnum( "WELDEDSHELLHERMETIC" );
		public static readonly IfcCompressorTypeEnum ROLLINGPISTON = new IfcCompressorTypeEnum( "ROLLINGPISTON" );
		public static readonly IfcCompressorTypeEnum ROTARYVANE = new IfcCompressorTypeEnum( "ROTARYVANE" );
		public static readonly IfcCompressorTypeEnum SINGLESCREW = new IfcCompressorTypeEnum( "SINGLESCREW" );
		public static readonly IfcCompressorTypeEnum TWINSCREW = new IfcCompressorTypeEnum( "TWINSCREW" );
		public static readonly IfcCompressorTypeEnum USERDEFINED = new IfcCompressorTypeEnum( "USERDEFINED" );
		public static readonly IfcCompressorTypeEnum NOTDEFINED = new IfcCompressorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCondenserTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCondenserTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCondenserTypeEnum AIRCOOLED = new IfcCondenserTypeEnum( "AIRCOOLED" );
		public static readonly IfcCondenserTypeEnum EVAPORATIVECOOLED = new IfcCondenserTypeEnum( "EVAPORATIVECOOLED" );
		public static readonly IfcCondenserTypeEnum WATERCOOLED = new IfcCondenserTypeEnum( "WATERCOOLED" );
		public static readonly IfcCondenserTypeEnum WATERCOOLEDBRAZEDPLATE = new IfcCondenserTypeEnum( "WATERCOOLEDBRAZEDPLATE" );
		public static readonly IfcCondenserTypeEnum WATERCOOLEDSHELLCOIL = new IfcCondenserTypeEnum( "WATERCOOLEDSHELLCOIL" );
		public static readonly IfcCondenserTypeEnum WATERCOOLEDSHELLTUBE = new IfcCondenserTypeEnum( "WATERCOOLEDSHELLTUBE" );
		public static readonly IfcCondenserTypeEnum WATERCOOLEDTUBEINTUBE = new IfcCondenserTypeEnum( "WATERCOOLEDTUBEINTUBE" );
		public static readonly IfcCondenserTypeEnum USERDEFINED = new IfcCondenserTypeEnum( "USERDEFINED" );
		public static readonly IfcCondenserTypeEnum NOTDEFINED = new IfcCondenserTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcConnectionTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcConnectionTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcConnectionTypeEnum ATPATH = new IfcConnectionTypeEnum( "ATPATH" );
		public static readonly IfcConnectionTypeEnum ATSTART = new IfcConnectionTypeEnum( "ATSTART" );
		public static readonly IfcConnectionTypeEnum ATEND = new IfcConnectionTypeEnum( "ATEND" );
		public static readonly IfcConnectionTypeEnum NOTDEFINED = new IfcConnectionTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcConstraintEnum : BaseType
	{
	private readonly string ename;
		private IfcConstraintEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcConstraintEnum HARD = new IfcConstraintEnum( "HARD" );
		public static readonly IfcConstraintEnum SOFT = new IfcConstraintEnum( "SOFT" );
		public static readonly IfcConstraintEnum ADVISORY = new IfcConstraintEnum( "ADVISORY" );
		public static readonly IfcConstraintEnum USERDEFINED = new IfcConstraintEnum( "USERDEFINED" );
		public static readonly IfcConstraintEnum NOTDEFINED = new IfcConstraintEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcConstructionEquipmentResourceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcConstructionEquipmentResourceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcConstructionEquipmentResourceTypeEnum DEMOLISHING = new IfcConstructionEquipmentResourceTypeEnum( "DEMOLISHING" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum EARTHMOVING = new IfcConstructionEquipmentResourceTypeEnum( "EARTHMOVING" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum ERECTING = new IfcConstructionEquipmentResourceTypeEnum( "ERECTING" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum HEATING = new IfcConstructionEquipmentResourceTypeEnum( "HEATING" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum LIGHTING = new IfcConstructionEquipmentResourceTypeEnum( "LIGHTING" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum PAVING = new IfcConstructionEquipmentResourceTypeEnum( "PAVING" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum PUMPING = new IfcConstructionEquipmentResourceTypeEnum( "PUMPING" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum TRANSPORTING = new IfcConstructionEquipmentResourceTypeEnum( "TRANSPORTING" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum USERDEFINED = new IfcConstructionEquipmentResourceTypeEnum( "USERDEFINED" );
		public static readonly IfcConstructionEquipmentResourceTypeEnum NOTDEFINED = new IfcConstructionEquipmentResourceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcConstructionMaterialResourceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcConstructionMaterialResourceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcConstructionMaterialResourceTypeEnum AGGREGATES = new IfcConstructionMaterialResourceTypeEnum( "AGGREGATES" );
		public static readonly IfcConstructionMaterialResourceTypeEnum CONCRETE = new IfcConstructionMaterialResourceTypeEnum( "CONCRETE" );
		public static readonly IfcConstructionMaterialResourceTypeEnum DRYWALL = new IfcConstructionMaterialResourceTypeEnum( "DRYWALL" );
		public static readonly IfcConstructionMaterialResourceTypeEnum FUEL = new IfcConstructionMaterialResourceTypeEnum( "FUEL" );
		public static readonly IfcConstructionMaterialResourceTypeEnum GYPSUM = new IfcConstructionMaterialResourceTypeEnum( "GYPSUM" );
		public static readonly IfcConstructionMaterialResourceTypeEnum MASONRY = new IfcConstructionMaterialResourceTypeEnum( "MASONRY" );
		public static readonly IfcConstructionMaterialResourceTypeEnum METAL = new IfcConstructionMaterialResourceTypeEnum( "METAL" );
		public static readonly IfcConstructionMaterialResourceTypeEnum PLASTIC = new IfcConstructionMaterialResourceTypeEnum( "PLASTIC" );
		public static readonly IfcConstructionMaterialResourceTypeEnum WOOD = new IfcConstructionMaterialResourceTypeEnum( "WOOD" );
		public static readonly IfcConstructionMaterialResourceTypeEnum NOTDEFINED = new IfcConstructionMaterialResourceTypeEnum( "NOTDEFINED" );
		public static readonly IfcConstructionMaterialResourceTypeEnum USERDEFINED = new IfcConstructionMaterialResourceTypeEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcConstructionProductResourceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcConstructionProductResourceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcConstructionProductResourceTypeEnum ASSEMBLY = new IfcConstructionProductResourceTypeEnum( "ASSEMBLY" );
		public static readonly IfcConstructionProductResourceTypeEnum FORMWORK = new IfcConstructionProductResourceTypeEnum( "FORMWORK" );
		public static readonly IfcConstructionProductResourceTypeEnum USERDEFINED = new IfcConstructionProductResourceTypeEnum( "USERDEFINED" );
		public static readonly IfcConstructionProductResourceTypeEnum NOTDEFINED = new IfcConstructionProductResourceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcControllerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcControllerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcControllerTypeEnum FLOATING = new IfcControllerTypeEnum( "FLOATING" );
		public static readonly IfcControllerTypeEnum PROGRAMMABLE = new IfcControllerTypeEnum( "PROGRAMMABLE" );
		public static readonly IfcControllerTypeEnum PROPORTIONAL = new IfcControllerTypeEnum( "PROPORTIONAL" );
		public static readonly IfcControllerTypeEnum MULTIPOSITION = new IfcControllerTypeEnum( "MULTIPOSITION" );
		public static readonly IfcControllerTypeEnum TWOPOSITION = new IfcControllerTypeEnum( "TWOPOSITION" );
		public static readonly IfcControllerTypeEnum USERDEFINED = new IfcControllerTypeEnum( "USERDEFINED" );
		public static readonly IfcControllerTypeEnum NOTDEFINED = new IfcControllerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCooledBeamTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCooledBeamTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCooledBeamTypeEnum ACTIVE = new IfcCooledBeamTypeEnum( "ACTIVE" );
		public static readonly IfcCooledBeamTypeEnum PASSIVE = new IfcCooledBeamTypeEnum( "PASSIVE" );
		public static readonly IfcCooledBeamTypeEnum USERDEFINED = new IfcCooledBeamTypeEnum( "USERDEFINED" );
		public static readonly IfcCooledBeamTypeEnum NOTDEFINED = new IfcCooledBeamTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCoolingTowerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCoolingTowerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCoolingTowerTypeEnum NATURALDRAFT = new IfcCoolingTowerTypeEnum( "NATURALDRAFT" );
		public static readonly IfcCoolingTowerTypeEnum MECHANICALINDUCEDDRAFT = new IfcCoolingTowerTypeEnum( "MECHANICALINDUCEDDRAFT" );
		public static readonly IfcCoolingTowerTypeEnum MECHANICALFORCEDDRAFT = new IfcCoolingTowerTypeEnum( "MECHANICALFORCEDDRAFT" );
		public static readonly IfcCoolingTowerTypeEnum USERDEFINED = new IfcCoolingTowerTypeEnum( "USERDEFINED" );
		public static readonly IfcCoolingTowerTypeEnum NOTDEFINED = new IfcCoolingTowerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCostItemTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCostItemTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCostItemTypeEnum USERDEFINED = new IfcCostItemTypeEnum( "USERDEFINED" );
		public static readonly IfcCostItemTypeEnum NOTDEFINED = new IfcCostItemTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCostScheduleTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCostScheduleTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCostScheduleTypeEnum BUDGET = new IfcCostScheduleTypeEnum( "BUDGET" );
		public static readonly IfcCostScheduleTypeEnum COSTPLAN = new IfcCostScheduleTypeEnum( "COSTPLAN" );
		public static readonly IfcCostScheduleTypeEnum ESTIMATE = new IfcCostScheduleTypeEnum( "ESTIMATE" );
		public static readonly IfcCostScheduleTypeEnum TENDER = new IfcCostScheduleTypeEnum( "TENDER" );
		public static readonly IfcCostScheduleTypeEnum PRICEDBILLOFQUANTITIES = new IfcCostScheduleTypeEnum( "PRICEDBILLOFQUANTITIES" );
		public static readonly IfcCostScheduleTypeEnum UNPRICEDBILLOFQUANTITIES = new IfcCostScheduleTypeEnum( "UNPRICEDBILLOFQUANTITIES" );
		public static readonly IfcCostScheduleTypeEnum SCHEDULEOFRATES = new IfcCostScheduleTypeEnum( "SCHEDULEOFRATES" );
		public static readonly IfcCostScheduleTypeEnum USERDEFINED = new IfcCostScheduleTypeEnum( "USERDEFINED" );
		public static readonly IfcCostScheduleTypeEnum NOTDEFINED = new IfcCostScheduleTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCoveringTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCoveringTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCoveringTypeEnum CEILING = new IfcCoveringTypeEnum( "CEILING" );
		public static readonly IfcCoveringTypeEnum FLOORING = new IfcCoveringTypeEnum( "FLOORING" );
		public static readonly IfcCoveringTypeEnum CLADDING = new IfcCoveringTypeEnum( "CLADDING" );
		public static readonly IfcCoveringTypeEnum ROOFING = new IfcCoveringTypeEnum( "ROOFING" );
		public static readonly IfcCoveringTypeEnum MOLDING = new IfcCoveringTypeEnum( "MOLDING" );
		public static readonly IfcCoveringTypeEnum SKIRTINGBOARD = new IfcCoveringTypeEnum( "SKIRTINGBOARD" );
		public static readonly IfcCoveringTypeEnum INSULATION = new IfcCoveringTypeEnum( "INSULATION" );
		public static readonly IfcCoveringTypeEnum MEMBRANE = new IfcCoveringTypeEnum( "MEMBRANE" );
		public static readonly IfcCoveringTypeEnum SLEEVING = new IfcCoveringTypeEnum( "SLEEVING" );
		public static readonly IfcCoveringTypeEnum WRAPPING = new IfcCoveringTypeEnum( "WRAPPING" );
		public static readonly IfcCoveringTypeEnum USERDEFINED = new IfcCoveringTypeEnum( "USERDEFINED" );
		public static readonly IfcCoveringTypeEnum NOTDEFINED = new IfcCoveringTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCrewResourceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCrewResourceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCrewResourceTypeEnum OFFICE = new IfcCrewResourceTypeEnum( "OFFICE" );
		public static readonly IfcCrewResourceTypeEnum SITE = new IfcCrewResourceTypeEnum( "SITE" );
		public static readonly IfcCrewResourceTypeEnum USERDEFINED = new IfcCrewResourceTypeEnum( "USERDEFINED" );
		public static readonly IfcCrewResourceTypeEnum NOTDEFINED = new IfcCrewResourceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCurtainWallTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcCurtainWallTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCurtainWallTypeEnum USERDEFINED = new IfcCurtainWallTypeEnum( "USERDEFINED" );
		public static readonly IfcCurtainWallTypeEnum NOTDEFINED = new IfcCurtainWallTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcCurveInterpolationEnum : BaseType
	{
	private readonly string ename;
		private IfcCurveInterpolationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcCurveInterpolationEnum LINEAR = new IfcCurveInterpolationEnum( "LINEAR" );
		public static readonly IfcCurveInterpolationEnum LOG_LINEAR = new IfcCurveInterpolationEnum( "LOG_LINEAR" );
		public static readonly IfcCurveInterpolationEnum LOG_LOG = new IfcCurveInterpolationEnum( "LOG_LOG" );
		public static readonly IfcCurveInterpolationEnum NOTDEFINED = new IfcCurveInterpolationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDamperTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDamperTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDamperTypeEnum BACKDRAFTDAMPER = new IfcDamperTypeEnum( "BACKDRAFTDAMPER" );
		public static readonly IfcDamperTypeEnum BALANCINGDAMPER = new IfcDamperTypeEnum( "BALANCINGDAMPER" );
		public static readonly IfcDamperTypeEnum BLASTDAMPER = new IfcDamperTypeEnum( "BLASTDAMPER" );
		public static readonly IfcDamperTypeEnum CONTROLDAMPER = new IfcDamperTypeEnum( "CONTROLDAMPER" );
		public static readonly IfcDamperTypeEnum FIREDAMPER = new IfcDamperTypeEnum( "FIREDAMPER" );
		public static readonly IfcDamperTypeEnum FIRESMOKEDAMPER = new IfcDamperTypeEnum( "FIRESMOKEDAMPER" );
		public static readonly IfcDamperTypeEnum FUMEHOODEXHAUST = new IfcDamperTypeEnum( "FUMEHOODEXHAUST" );
		public static readonly IfcDamperTypeEnum GRAVITYDAMPER = new IfcDamperTypeEnum( "GRAVITYDAMPER" );
		public static readonly IfcDamperTypeEnum GRAVITYRELIEFDAMPER = new IfcDamperTypeEnum( "GRAVITYRELIEFDAMPER" );
		public static readonly IfcDamperTypeEnum RELIEFDAMPER = new IfcDamperTypeEnum( "RELIEFDAMPER" );
		public static readonly IfcDamperTypeEnum SMOKEDAMPER = new IfcDamperTypeEnum( "SMOKEDAMPER" );
		public static readonly IfcDamperTypeEnum USERDEFINED = new IfcDamperTypeEnum( "USERDEFINED" );
		public static readonly IfcDamperTypeEnum NOTDEFINED = new IfcDamperTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDataOriginEnum : BaseType
	{
	private readonly string ename;
		private IfcDataOriginEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDataOriginEnum MEASURED = new IfcDataOriginEnum( "MEASURED" );
		public static readonly IfcDataOriginEnum PREDICTED = new IfcDataOriginEnum( "PREDICTED" );
		public static readonly IfcDataOriginEnum SIMULATED = new IfcDataOriginEnum( "SIMULATED" );
		public static readonly IfcDataOriginEnum USERDEFINED = new IfcDataOriginEnum( "USERDEFINED" );
		public static readonly IfcDataOriginEnum NOTDEFINED = new IfcDataOriginEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDerivedUnitEnum : BaseType
	{
	private readonly string ename;
		private IfcDerivedUnitEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDerivedUnitEnum ANGULARVELOCITYUNIT = new IfcDerivedUnitEnum( "ANGULARVELOCITYUNIT" );
		public static readonly IfcDerivedUnitEnum AREADENSITYUNIT = new IfcDerivedUnitEnum( "AREADENSITYUNIT" );
		public static readonly IfcDerivedUnitEnum COMPOUNDPLANEANGLEUNIT = new IfcDerivedUnitEnum( "COMPOUNDPLANEANGLEUNIT" );
		public static readonly IfcDerivedUnitEnum DYNAMICVISCOSITYUNIT = new IfcDerivedUnitEnum( "DYNAMICVISCOSITYUNIT" );
		public static readonly IfcDerivedUnitEnum HEATFLUXDENSITYUNIT = new IfcDerivedUnitEnum( "HEATFLUXDENSITYUNIT" );
		public static readonly IfcDerivedUnitEnum INTEGERCOUNTRATEUNIT = new IfcDerivedUnitEnum( "INTEGERCOUNTRATEUNIT" );
		public static readonly IfcDerivedUnitEnum ISOTHERMALMOISTURECAPACITYUNIT = new IfcDerivedUnitEnum( "ISOTHERMALMOISTURECAPACITYUNIT" );
		public static readonly IfcDerivedUnitEnum KINEMATICVISCOSITYUNIT = new IfcDerivedUnitEnum( "KINEMATICVISCOSITYUNIT" );
		public static readonly IfcDerivedUnitEnum LINEARVELOCITYUNIT = new IfcDerivedUnitEnum( "LINEARVELOCITYUNIT" );
		public static readonly IfcDerivedUnitEnum MASSDENSITYUNIT = new IfcDerivedUnitEnum( "MASSDENSITYUNIT" );
		public static readonly IfcDerivedUnitEnum MASSFLOWRATEUNIT = new IfcDerivedUnitEnum( "MASSFLOWRATEUNIT" );
		public static readonly IfcDerivedUnitEnum MOISTUREDIFFUSIVITYUNIT = new IfcDerivedUnitEnum( "MOISTUREDIFFUSIVITYUNIT" );
		public static readonly IfcDerivedUnitEnum MOLECULARWEIGHTUNIT = new IfcDerivedUnitEnum( "MOLECULARWEIGHTUNIT" );
		public static readonly IfcDerivedUnitEnum SPECIFICHEATCAPACITYUNIT = new IfcDerivedUnitEnum( "SPECIFICHEATCAPACITYUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALADMITTANCEUNIT = new IfcDerivedUnitEnum( "THERMALADMITTANCEUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALCONDUCTANCEUNIT = new IfcDerivedUnitEnum( "THERMALCONDUCTANCEUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALRESISTANCEUNIT = new IfcDerivedUnitEnum( "THERMALRESISTANCEUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALTRANSMITTANCEUNIT = new IfcDerivedUnitEnum( "THERMALTRANSMITTANCEUNIT" );
		public static readonly IfcDerivedUnitEnum VAPORPERMEABILITYUNIT = new IfcDerivedUnitEnum( "VAPORPERMEABILITYUNIT" );
		public static readonly IfcDerivedUnitEnum VOLUMETRICFLOWRATEUNIT = new IfcDerivedUnitEnum( "VOLUMETRICFLOWRATEUNIT" );
		public static readonly IfcDerivedUnitEnum ROTATIONALFREQUENCYUNIT = new IfcDerivedUnitEnum( "ROTATIONALFREQUENCYUNIT" );
		public static readonly IfcDerivedUnitEnum TORQUEUNIT = new IfcDerivedUnitEnum( "TORQUEUNIT" );
		public static readonly IfcDerivedUnitEnum MOMENTOFINERTIAUNIT = new IfcDerivedUnitEnum( "MOMENTOFINERTIAUNIT" );
		public static readonly IfcDerivedUnitEnum LINEARMOMENTUNIT = new IfcDerivedUnitEnum( "LINEARMOMENTUNIT" );
		public static readonly IfcDerivedUnitEnum LINEARFORCEUNIT = new IfcDerivedUnitEnum( "LINEARFORCEUNIT" );
		public static readonly IfcDerivedUnitEnum PLANARFORCEUNIT = new IfcDerivedUnitEnum( "PLANARFORCEUNIT" );
		public static readonly IfcDerivedUnitEnum MODULUSOFELASTICITYUNIT = new IfcDerivedUnitEnum( "MODULUSOFELASTICITYUNIT" );
		public static readonly IfcDerivedUnitEnum SHEARMODULUSUNIT = new IfcDerivedUnitEnum( "SHEARMODULUSUNIT" );
		public static readonly IfcDerivedUnitEnum LINEARSTIFFNESSUNIT = new IfcDerivedUnitEnum( "LINEARSTIFFNESSUNIT" );
		public static readonly IfcDerivedUnitEnum ROTATIONALSTIFFNESSUNIT = new IfcDerivedUnitEnum( "ROTATIONALSTIFFNESSUNIT" );
		public static readonly IfcDerivedUnitEnum MODULUSOFSUBGRADEREACTIONUNIT = new IfcDerivedUnitEnum( "MODULUSOFSUBGRADEREACTIONUNIT" );
		public static readonly IfcDerivedUnitEnum ACCELERATIONUNIT = new IfcDerivedUnitEnum( "ACCELERATIONUNIT" );
		public static readonly IfcDerivedUnitEnum CURVATUREUNIT = new IfcDerivedUnitEnum( "CURVATUREUNIT" );
		public static readonly IfcDerivedUnitEnum HEATINGVALUEUNIT = new IfcDerivedUnitEnum( "HEATINGVALUEUNIT" );
		public static readonly IfcDerivedUnitEnum IONCONCENTRATIONUNIT = new IfcDerivedUnitEnum( "IONCONCENTRATIONUNIT" );
		public static readonly IfcDerivedUnitEnum LUMINOUSINTENSITYDISTRIBUTIONUNIT = new IfcDerivedUnitEnum( "LUMINOUSINTENSITYDISTRIBUTIONUNIT" );
		public static readonly IfcDerivedUnitEnum MASSPERLENGTHUNIT = new IfcDerivedUnitEnum( "MASSPERLENGTHUNIT" );
		public static readonly IfcDerivedUnitEnum MODULUSOFLINEARSUBGRADEREACTIONUNIT = new IfcDerivedUnitEnum( "MODULUSOFLINEARSUBGRADEREACTIONUNIT" );
		public static readonly IfcDerivedUnitEnum MODULUSOFROTATIONALSUBGRADEREACTIONUNIT = new IfcDerivedUnitEnum( "MODULUSOFROTATIONALSUBGRADEREACTIONUNIT" );
		public static readonly IfcDerivedUnitEnum PHUNIT = new IfcDerivedUnitEnum( "PHUNIT" );
		public static readonly IfcDerivedUnitEnum ROTATIONALMASSUNIT = new IfcDerivedUnitEnum( "ROTATIONALMASSUNIT" );
		public static readonly IfcDerivedUnitEnum SECTIONAREAINTEGRALUNIT = new IfcDerivedUnitEnum( "SECTIONAREAINTEGRALUNIT" );
		public static readonly IfcDerivedUnitEnum SECTIONMODULUSUNIT = new IfcDerivedUnitEnum( "SECTIONMODULUSUNIT" );
		public static readonly IfcDerivedUnitEnum SOUNDPOWERLEVELUNIT = new IfcDerivedUnitEnum( "SOUNDPOWERLEVELUNIT" );
		public static readonly IfcDerivedUnitEnum SOUNDPOWERUNIT = new IfcDerivedUnitEnum( "SOUNDPOWERUNIT" );
		public static readonly IfcDerivedUnitEnum SOUNDPRESSURELEVELUNIT = new IfcDerivedUnitEnum( "SOUNDPRESSURELEVELUNIT" );
		public static readonly IfcDerivedUnitEnum SOUNDPRESSUREUNIT = new IfcDerivedUnitEnum( "SOUNDPRESSUREUNIT" );
		public static readonly IfcDerivedUnitEnum TEMPERATUREGRADIENTUNIT = new IfcDerivedUnitEnum( "TEMPERATUREGRADIENTUNIT" );
		public static readonly IfcDerivedUnitEnum TEMPERATURERATEOFCHANGEUNIT = new IfcDerivedUnitEnum( "TEMPERATURERATEOFCHANGEUNIT" );
		public static readonly IfcDerivedUnitEnum THERMALEXPANSIONCOEFFICIENTUNIT = new IfcDerivedUnitEnum( "THERMALEXPANSIONCOEFFICIENTUNIT" );
		public static readonly IfcDerivedUnitEnum WARPINGCONSTANTUNIT = new IfcDerivedUnitEnum( "WARPINGCONSTANTUNIT" );
		public static readonly IfcDerivedUnitEnum WARPINGMOMENTUNIT = new IfcDerivedUnitEnum( "WARPINGMOMENTUNIT" );
		public static readonly IfcDerivedUnitEnum USERDEFINED = new IfcDerivedUnitEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDirectionSenseEnum : BaseType
	{
	private readonly string ename;
		private IfcDirectionSenseEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDirectionSenseEnum POSITIVE = new IfcDirectionSenseEnum( "POSITIVE" );
		public static readonly IfcDirectionSenseEnum NEGATIVE = new IfcDirectionSenseEnum( "NEGATIVE" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDiscreteAccessoryTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDiscreteAccessoryTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDiscreteAccessoryTypeEnum ANCHORPLATE = new IfcDiscreteAccessoryTypeEnum( "ANCHORPLATE" );
		public static readonly IfcDiscreteAccessoryTypeEnum BRACKET = new IfcDiscreteAccessoryTypeEnum( "BRACKET" );
		public static readonly IfcDiscreteAccessoryTypeEnum SHOE = new IfcDiscreteAccessoryTypeEnum( "SHOE" );
		public static readonly IfcDiscreteAccessoryTypeEnum USERDEFINED = new IfcDiscreteAccessoryTypeEnum( "USERDEFINED" );
		public static readonly IfcDiscreteAccessoryTypeEnum NOTDEFINED = new IfcDiscreteAccessoryTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDistributionChamberElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDistributionChamberElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDistributionChamberElementTypeEnum FORMEDDUCT = new IfcDistributionChamberElementTypeEnum( "FORMEDDUCT" );
		public static readonly IfcDistributionChamberElementTypeEnum INSPECTIONCHAMBER = new IfcDistributionChamberElementTypeEnum( "INSPECTIONCHAMBER" );
		public static readonly IfcDistributionChamberElementTypeEnum INSPECTIONPIT = new IfcDistributionChamberElementTypeEnum( "INSPECTIONPIT" );
		public static readonly IfcDistributionChamberElementTypeEnum MANHOLE = new IfcDistributionChamberElementTypeEnum( "MANHOLE" );
		public static readonly IfcDistributionChamberElementTypeEnum METERCHAMBER = new IfcDistributionChamberElementTypeEnum( "METERCHAMBER" );
		public static readonly IfcDistributionChamberElementTypeEnum SUMP = new IfcDistributionChamberElementTypeEnum( "SUMP" );
		public static readonly IfcDistributionChamberElementTypeEnum TRENCH = new IfcDistributionChamberElementTypeEnum( "TRENCH" );
		public static readonly IfcDistributionChamberElementTypeEnum VALVECHAMBER = new IfcDistributionChamberElementTypeEnum( "VALVECHAMBER" );
		public static readonly IfcDistributionChamberElementTypeEnum USERDEFINED = new IfcDistributionChamberElementTypeEnum( "USERDEFINED" );
		public static readonly IfcDistributionChamberElementTypeEnum NOTDEFINED = new IfcDistributionChamberElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDistributionPortTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDistributionPortTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDistributionPortTypeEnum CABLE = new IfcDistributionPortTypeEnum( "CABLE" );
		public static readonly IfcDistributionPortTypeEnum CABLECARRIER = new IfcDistributionPortTypeEnum( "CABLECARRIER" );
		public static readonly IfcDistributionPortTypeEnum DUCT = new IfcDistributionPortTypeEnum( "DUCT" );
		public static readonly IfcDistributionPortTypeEnum PIPE = new IfcDistributionPortTypeEnum( "PIPE" );
		public static readonly IfcDistributionPortTypeEnum USERDEFINED = new IfcDistributionPortTypeEnum( "USERDEFINED" );
		public static readonly IfcDistributionPortTypeEnum NOTDEFINED = new IfcDistributionPortTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDistributionSystemEnum : BaseType
	{
	private readonly string ename;
		private IfcDistributionSystemEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDistributionSystemEnum AIRCONDITIONING = new IfcDistributionSystemEnum( "AIRCONDITIONING" );
		public static readonly IfcDistributionSystemEnum AUDIOVISUAL = new IfcDistributionSystemEnum( "AUDIOVISUAL" );
		public static readonly IfcDistributionSystemEnum CHEMICAL = new IfcDistributionSystemEnum( "CHEMICAL" );
		public static readonly IfcDistributionSystemEnum CHILLEDWATER = new IfcDistributionSystemEnum( "CHILLEDWATER" );
		public static readonly IfcDistributionSystemEnum COMMUNICATION = new IfcDistributionSystemEnum( "COMMUNICATION" );
		public static readonly IfcDistributionSystemEnum COMPRESSEDAIR = new IfcDistributionSystemEnum( "COMPRESSEDAIR" );
		public static readonly IfcDistributionSystemEnum CONDENSERWATER = new IfcDistributionSystemEnum( "CONDENSERWATER" );
		public static readonly IfcDistributionSystemEnum CONTROL = new IfcDistributionSystemEnum( "CONTROL" );
		public static readonly IfcDistributionSystemEnum CONVEYING = new IfcDistributionSystemEnum( "CONVEYING" );
		public static readonly IfcDistributionSystemEnum DATA = new IfcDistributionSystemEnum( "DATA" );
		public static readonly IfcDistributionSystemEnum DISPOSAL = new IfcDistributionSystemEnum( "DISPOSAL" );
		public static readonly IfcDistributionSystemEnum DOMESTICCOLDWATER = new IfcDistributionSystemEnum( "DOMESTICCOLDWATER" );
		public static readonly IfcDistributionSystemEnum DOMESTICHOTWATER = new IfcDistributionSystemEnum( "DOMESTICHOTWATER" );
		public static readonly IfcDistributionSystemEnum DRAINAGE = new IfcDistributionSystemEnum( "DRAINAGE" );
		public static readonly IfcDistributionSystemEnum EARTHING = new IfcDistributionSystemEnum( "EARTHING" );
		public static readonly IfcDistributionSystemEnum ELECTRICAL = new IfcDistributionSystemEnum( "ELECTRICAL" );
		public static readonly IfcDistributionSystemEnum ELECTROACOUSTIC = new IfcDistributionSystemEnum( "ELECTROACOUSTIC" );
		public static readonly IfcDistributionSystemEnum EXHAUST = new IfcDistributionSystemEnum( "EXHAUST" );
		public static readonly IfcDistributionSystemEnum FIREPROTECTION = new IfcDistributionSystemEnum( "FIREPROTECTION" );
		public static readonly IfcDistributionSystemEnum FUEL = new IfcDistributionSystemEnum( "FUEL" );
		public static readonly IfcDistributionSystemEnum GAS = new IfcDistributionSystemEnum( "GAS" );
		public static readonly IfcDistributionSystemEnum HAZARDOUS = new IfcDistributionSystemEnum( "HAZARDOUS" );
		public static readonly IfcDistributionSystemEnum HEATING = new IfcDistributionSystemEnum( "HEATING" );
		public static readonly IfcDistributionSystemEnum LIGHTING = new IfcDistributionSystemEnum( "LIGHTING" );
		public static readonly IfcDistributionSystemEnum LIGHTNINGPROTECTION = new IfcDistributionSystemEnum( "LIGHTNINGPROTECTION" );
		public static readonly IfcDistributionSystemEnum MUNICIPALSOLIDWASTE = new IfcDistributionSystemEnum( "MUNICIPALSOLIDWASTE" );
		public static readonly IfcDistributionSystemEnum OIL = new IfcDistributionSystemEnum( "OIL" );
		public static readonly IfcDistributionSystemEnum OPERATIONAL = new IfcDistributionSystemEnum( "OPERATIONAL" );
		public static readonly IfcDistributionSystemEnum POWERGENERATION = new IfcDistributionSystemEnum( "POWERGENERATION" );
		public static readonly IfcDistributionSystemEnum RAINWATER = new IfcDistributionSystemEnum( "RAINWATER" );
		public static readonly IfcDistributionSystemEnum REFRIGERATION = new IfcDistributionSystemEnum( "REFRIGERATION" );
		public static readonly IfcDistributionSystemEnum SECURITY = new IfcDistributionSystemEnum( "SECURITY" );
		public static readonly IfcDistributionSystemEnum SEWAGE = new IfcDistributionSystemEnum( "SEWAGE" );
		public static readonly IfcDistributionSystemEnum SIGNAL = new IfcDistributionSystemEnum( "SIGNAL" );
		public static readonly IfcDistributionSystemEnum STORMWATER = new IfcDistributionSystemEnum( "STORMWATER" );
		public static readonly IfcDistributionSystemEnum TELEPHONE = new IfcDistributionSystemEnum( "TELEPHONE" );
		public static readonly IfcDistributionSystemEnum TV = new IfcDistributionSystemEnum( "TV" );
		public static readonly IfcDistributionSystemEnum VACUUM = new IfcDistributionSystemEnum( "VACUUM" );
		public static readonly IfcDistributionSystemEnum VENT = new IfcDistributionSystemEnum( "VENT" );
		public static readonly IfcDistributionSystemEnum VENTILATION = new IfcDistributionSystemEnum( "VENTILATION" );
		public static readonly IfcDistributionSystemEnum WASTEWATER = new IfcDistributionSystemEnum( "WASTEWATER" );
		public static readonly IfcDistributionSystemEnum WATERSUPPLY = new IfcDistributionSystemEnum( "WATERSUPPLY" );
		public static readonly IfcDistributionSystemEnum USERDEFINED = new IfcDistributionSystemEnum( "USERDEFINED" );
		public static readonly IfcDistributionSystemEnum NOTDEFINED = new IfcDistributionSystemEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDocumentConfidentialityEnum : BaseType
	{
	private readonly string ename;
		private IfcDocumentConfidentialityEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDocumentConfidentialityEnum PUBLIC = new IfcDocumentConfidentialityEnum( "PUBLIC" );
		public static readonly IfcDocumentConfidentialityEnum RESTRICTED = new IfcDocumentConfidentialityEnum( "RESTRICTED" );
		public static readonly IfcDocumentConfidentialityEnum CONFIDENTIAL = new IfcDocumentConfidentialityEnum( "CONFIDENTIAL" );
		public static readonly IfcDocumentConfidentialityEnum PERSONAL = new IfcDocumentConfidentialityEnum( "PERSONAL" );
		public static readonly IfcDocumentConfidentialityEnum USERDEFINED = new IfcDocumentConfidentialityEnum( "USERDEFINED" );
		public static readonly IfcDocumentConfidentialityEnum NOTDEFINED = new IfcDocumentConfidentialityEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDocumentStatusEnum : BaseType
	{
	private readonly string ename;
		private IfcDocumentStatusEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDocumentStatusEnum DRAFT = new IfcDocumentStatusEnum( "DRAFT" );
		public static readonly IfcDocumentStatusEnum FINALDRAFT = new IfcDocumentStatusEnum( "FINALDRAFT" );
		public static readonly IfcDocumentStatusEnum FINAL = new IfcDocumentStatusEnum( "FINAL" );
		public static readonly IfcDocumentStatusEnum REVISION = new IfcDocumentStatusEnum( "REVISION" );
		public static readonly IfcDocumentStatusEnum NOTDEFINED = new IfcDocumentStatusEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorPanelOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorPanelOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorPanelOperationEnum SWINGING = new IfcDoorPanelOperationEnum( "SWINGING" );
		public static readonly IfcDoorPanelOperationEnum DOUBLE_ACTING = new IfcDoorPanelOperationEnum( "DOUBLE_ACTING" );
		public static readonly IfcDoorPanelOperationEnum SLIDING = new IfcDoorPanelOperationEnum( "SLIDING" );
		public static readonly IfcDoorPanelOperationEnum FOLDING = new IfcDoorPanelOperationEnum( "FOLDING" );
		public static readonly IfcDoorPanelOperationEnum REVOLVING = new IfcDoorPanelOperationEnum( "REVOLVING" );
		public static readonly IfcDoorPanelOperationEnum ROLLINGUP = new IfcDoorPanelOperationEnum( "ROLLINGUP" );
		public static readonly IfcDoorPanelOperationEnum FIXEDPANEL = new IfcDoorPanelOperationEnum( "FIXEDPANEL" );
		public static readonly IfcDoorPanelOperationEnum USERDEFINED = new IfcDoorPanelOperationEnum( "USERDEFINED" );
		public static readonly IfcDoorPanelOperationEnum NOTDEFINED = new IfcDoorPanelOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorPanelPositionEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorPanelPositionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorPanelPositionEnum LEFT = new IfcDoorPanelPositionEnum( "LEFT" );
		public static readonly IfcDoorPanelPositionEnum MIDDLE = new IfcDoorPanelPositionEnum( "MIDDLE" );
		public static readonly IfcDoorPanelPositionEnum RIGHT = new IfcDoorPanelPositionEnum( "RIGHT" );
		public static readonly IfcDoorPanelPositionEnum NOTDEFINED = new IfcDoorPanelPositionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorStyleConstructionEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorStyleConstructionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorStyleConstructionEnum ALUMINIUM = new IfcDoorStyleConstructionEnum( "ALUMINIUM" );
		public static readonly IfcDoorStyleConstructionEnum HIGH_GRADE_STEEL = new IfcDoorStyleConstructionEnum( "HIGH_GRADE_STEEL" );
		public static readonly IfcDoorStyleConstructionEnum STEEL = new IfcDoorStyleConstructionEnum( "STEEL" );
		public static readonly IfcDoorStyleConstructionEnum WOOD = new IfcDoorStyleConstructionEnum( "WOOD" );
		public static readonly IfcDoorStyleConstructionEnum ALUMINIUM_WOOD = new IfcDoorStyleConstructionEnum( "ALUMINIUM_WOOD" );
		public static readonly IfcDoorStyleConstructionEnum ALUMINIUM_PLASTIC = new IfcDoorStyleConstructionEnum( "ALUMINIUM_PLASTIC" );
		public static readonly IfcDoorStyleConstructionEnum PLASTIC = new IfcDoorStyleConstructionEnum( "PLASTIC" );
		public static readonly IfcDoorStyleConstructionEnum USERDEFINED = new IfcDoorStyleConstructionEnum( "USERDEFINED" );
		public static readonly IfcDoorStyleConstructionEnum NOTDEFINED = new IfcDoorStyleConstructionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorStyleOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorStyleOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorStyleOperationEnum SINGLE_SWING_LEFT = new IfcDoorStyleOperationEnum( "SINGLE_SWING_LEFT" );
		public static readonly IfcDoorStyleOperationEnum SINGLE_SWING_RIGHT = new IfcDoorStyleOperationEnum( "SINGLE_SWING_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_SINGLE_SWING = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_SINGLE_SWING" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_SWING_LEFT = new IfcDoorStyleOperationEnum( "DOUBLE_SWING_LEFT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_SWING_RIGHT = new IfcDoorStyleOperationEnum( "DOUBLE_SWING_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_DOUBLE_SWING = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_DOUBLE_SWING" );
		public static readonly IfcDoorStyleOperationEnum SLIDING_TO_LEFT = new IfcDoorStyleOperationEnum( "SLIDING_TO_LEFT" );
		public static readonly IfcDoorStyleOperationEnum SLIDING_TO_RIGHT = new IfcDoorStyleOperationEnum( "SLIDING_TO_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_SLIDING = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_SLIDING" );
		public static readonly IfcDoorStyleOperationEnum FOLDING_TO_LEFT = new IfcDoorStyleOperationEnum( "FOLDING_TO_LEFT" );
		public static readonly IfcDoorStyleOperationEnum FOLDING_TO_RIGHT = new IfcDoorStyleOperationEnum( "FOLDING_TO_RIGHT" );
		public static readonly IfcDoorStyleOperationEnum DOUBLE_DOOR_FOLDING = new IfcDoorStyleOperationEnum( "DOUBLE_DOOR_FOLDING" );
		public static readonly IfcDoorStyleOperationEnum REVOLVING = new IfcDoorStyleOperationEnum( "REVOLVING" );
		public static readonly IfcDoorStyleOperationEnum ROLLINGUP = new IfcDoorStyleOperationEnum( "ROLLINGUP" );
		public static readonly IfcDoorStyleOperationEnum USERDEFINED = new IfcDoorStyleOperationEnum( "USERDEFINED" );
		public static readonly IfcDoorStyleOperationEnum NOTDEFINED = new IfcDoorStyleOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorTypeEnum DOOR = new IfcDoorTypeEnum( "DOOR" );
		public static readonly IfcDoorTypeEnum GATE = new IfcDoorTypeEnum( "GATE" );
		public static readonly IfcDoorTypeEnum TRAPDOOR = new IfcDoorTypeEnum( "TRAPDOOR" );
		public static readonly IfcDoorTypeEnum USERDEFINED = new IfcDoorTypeEnum( "USERDEFINED" );
		public static readonly IfcDoorTypeEnum NOTDEFINED = new IfcDoorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDoorTypeOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcDoorTypeOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDoorTypeOperationEnum SINGLE_SWING_LEFT = new IfcDoorTypeOperationEnum( "SINGLE_SWING_LEFT" );
		public static readonly IfcDoorTypeOperationEnum SINGLE_SWING_RIGHT = new IfcDoorTypeOperationEnum( "SINGLE_SWING_RIGHT" );
		public static readonly IfcDoorTypeOperationEnum DOUBLE_DOOR_SINGLE_SWING = new IfcDoorTypeOperationEnum( "DOUBLE_DOOR_SINGLE_SWING" );
		public static readonly IfcDoorTypeOperationEnum DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT = new IfcDoorTypeOperationEnum( "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT" );
		public static readonly IfcDoorTypeOperationEnum DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT = new IfcDoorTypeOperationEnum( "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT" );
		public static readonly IfcDoorTypeOperationEnum DOUBLE_SWING_LEFT = new IfcDoorTypeOperationEnum( "DOUBLE_SWING_LEFT" );
		public static readonly IfcDoorTypeOperationEnum DOUBLE_SWING_RIGHT = new IfcDoorTypeOperationEnum( "DOUBLE_SWING_RIGHT" );
		public static readonly IfcDoorTypeOperationEnum DOUBLE_DOOR_DOUBLE_SWING = new IfcDoorTypeOperationEnum( "DOUBLE_DOOR_DOUBLE_SWING" );
		public static readonly IfcDoorTypeOperationEnum SLIDING_TO_LEFT = new IfcDoorTypeOperationEnum( "SLIDING_TO_LEFT" );
		public static readonly IfcDoorTypeOperationEnum SLIDING_TO_RIGHT = new IfcDoorTypeOperationEnum( "SLIDING_TO_RIGHT" );
		public static readonly IfcDoorTypeOperationEnum DOUBLE_DOOR_SLIDING = new IfcDoorTypeOperationEnum( "DOUBLE_DOOR_SLIDING" );
		public static readonly IfcDoorTypeOperationEnum FOLDING_TO_LEFT = new IfcDoorTypeOperationEnum( "FOLDING_TO_LEFT" );
		public static readonly IfcDoorTypeOperationEnum FOLDING_TO_RIGHT = new IfcDoorTypeOperationEnum( "FOLDING_TO_RIGHT" );
		public static readonly IfcDoorTypeOperationEnum DOUBLE_DOOR_FOLDING = new IfcDoorTypeOperationEnum( "DOUBLE_DOOR_FOLDING" );
		public static readonly IfcDoorTypeOperationEnum REVOLVING = new IfcDoorTypeOperationEnum( "REVOLVING" );
		public static readonly IfcDoorTypeOperationEnum ROLLINGUP = new IfcDoorTypeOperationEnum( "ROLLINGUP" );
		public static readonly IfcDoorTypeOperationEnum SWING_FIXED_LEFT = new IfcDoorTypeOperationEnum( "SWING_FIXED_LEFT" );
		public static readonly IfcDoorTypeOperationEnum SWING_FIXED_RIGHT = new IfcDoorTypeOperationEnum( "SWING_FIXED_RIGHT" );
		public static readonly IfcDoorTypeOperationEnum USERDEFINED = new IfcDoorTypeOperationEnum( "USERDEFINED" );
		public static readonly IfcDoorTypeOperationEnum NOTDEFINED = new IfcDoorTypeOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDuctFittingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDuctFittingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDuctFittingTypeEnum BEND = new IfcDuctFittingTypeEnum( "BEND" );
		public static readonly IfcDuctFittingTypeEnum CONNECTOR = new IfcDuctFittingTypeEnum( "CONNECTOR" );
		public static readonly IfcDuctFittingTypeEnum ENTRY = new IfcDuctFittingTypeEnum( "ENTRY" );
		public static readonly IfcDuctFittingTypeEnum EXIT = new IfcDuctFittingTypeEnum( "EXIT" );
		public static readonly IfcDuctFittingTypeEnum JUNCTION = new IfcDuctFittingTypeEnum( "JUNCTION" );
		public static readonly IfcDuctFittingTypeEnum OBSTRUCTION = new IfcDuctFittingTypeEnum( "OBSTRUCTION" );
		public static readonly IfcDuctFittingTypeEnum TRANSITION = new IfcDuctFittingTypeEnum( "TRANSITION" );
		public static readonly IfcDuctFittingTypeEnum USERDEFINED = new IfcDuctFittingTypeEnum( "USERDEFINED" );
		public static readonly IfcDuctFittingTypeEnum NOTDEFINED = new IfcDuctFittingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDuctSegmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDuctSegmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDuctSegmentTypeEnum RIGIDSEGMENT = new IfcDuctSegmentTypeEnum( "RIGIDSEGMENT" );
		public static readonly IfcDuctSegmentTypeEnum FLEXIBLESEGMENT = new IfcDuctSegmentTypeEnum( "FLEXIBLESEGMENT" );
		public static readonly IfcDuctSegmentTypeEnum USERDEFINED = new IfcDuctSegmentTypeEnum( "USERDEFINED" );
		public static readonly IfcDuctSegmentTypeEnum NOTDEFINED = new IfcDuctSegmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcDuctSilencerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcDuctSilencerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcDuctSilencerTypeEnum FLATOVAL = new IfcDuctSilencerTypeEnum( "FLATOVAL" );
		public static readonly IfcDuctSilencerTypeEnum RECTANGULAR = new IfcDuctSilencerTypeEnum( "RECTANGULAR" );
		public static readonly IfcDuctSilencerTypeEnum ROUND = new IfcDuctSilencerTypeEnum( "ROUND" );
		public static readonly IfcDuctSilencerTypeEnum USERDEFINED = new IfcDuctSilencerTypeEnum( "USERDEFINED" );
		public static readonly IfcDuctSilencerTypeEnum NOTDEFINED = new IfcDuctSilencerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricApplianceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricApplianceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricApplianceTypeEnum DISHWASHER = new IfcElectricApplianceTypeEnum( "DISHWASHER" );
		public static readonly IfcElectricApplianceTypeEnum ELECTRICCOOKER = new IfcElectricApplianceTypeEnum( "ELECTRICCOOKER" );
		public static readonly IfcElectricApplianceTypeEnum FREESTANDINGELECTRICHEATER = new IfcElectricApplianceTypeEnum( "FREESTANDINGELECTRICHEATER" );
		public static readonly IfcElectricApplianceTypeEnum FREESTANDINGFAN = new IfcElectricApplianceTypeEnum( "FREESTANDINGFAN" );
		public static readonly IfcElectricApplianceTypeEnum FREESTANDINGWATERHEATER = new IfcElectricApplianceTypeEnum( "FREESTANDINGWATERHEATER" );
		public static readonly IfcElectricApplianceTypeEnum FREESTANDINGWATERCOOLER = new IfcElectricApplianceTypeEnum( "FREESTANDINGWATERCOOLER" );
		public static readonly IfcElectricApplianceTypeEnum FREEZER = new IfcElectricApplianceTypeEnum( "FREEZER" );
		public static readonly IfcElectricApplianceTypeEnum FRIDGE_FREEZER = new IfcElectricApplianceTypeEnum( "FRIDGE_FREEZER" );
		public static readonly IfcElectricApplianceTypeEnum HANDDRYER = new IfcElectricApplianceTypeEnum( "HANDDRYER" );
		public static readonly IfcElectricApplianceTypeEnum KITCHENMACHINE = new IfcElectricApplianceTypeEnum( "KITCHENMACHINE" );
		public static readonly IfcElectricApplianceTypeEnum MICROWAVE = new IfcElectricApplianceTypeEnum( "MICROWAVE" );
		public static readonly IfcElectricApplianceTypeEnum PHOTOCOPIER = new IfcElectricApplianceTypeEnum( "PHOTOCOPIER" );
		public static readonly IfcElectricApplianceTypeEnum REFRIGERATOR = new IfcElectricApplianceTypeEnum( "REFRIGERATOR" );
		public static readonly IfcElectricApplianceTypeEnum TUMBLEDRYER = new IfcElectricApplianceTypeEnum( "TUMBLEDRYER" );
		public static readonly IfcElectricApplianceTypeEnum VENDINGMACHINE = new IfcElectricApplianceTypeEnum( "VENDINGMACHINE" );
		public static readonly IfcElectricApplianceTypeEnum WASHINGMACHINE = new IfcElectricApplianceTypeEnum( "WASHINGMACHINE" );
		public static readonly IfcElectricApplianceTypeEnum USERDEFINED = new IfcElectricApplianceTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricApplianceTypeEnum NOTDEFINED = new IfcElectricApplianceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricDistributionBoardTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricDistributionBoardTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricDistributionBoardTypeEnum CONSUMERUNIT = new IfcElectricDistributionBoardTypeEnum( "CONSUMERUNIT" );
		public static readonly IfcElectricDistributionBoardTypeEnum DISTRIBUTIONBOARD = new IfcElectricDistributionBoardTypeEnum( "DISTRIBUTIONBOARD" );
		public static readonly IfcElectricDistributionBoardTypeEnum MOTORCONTROLCENTRE = new IfcElectricDistributionBoardTypeEnum( "MOTORCONTROLCENTRE" );
		public static readonly IfcElectricDistributionBoardTypeEnum SWITCHBOARD = new IfcElectricDistributionBoardTypeEnum( "SWITCHBOARD" );
		public static readonly IfcElectricDistributionBoardTypeEnum USERDEFINED = new IfcElectricDistributionBoardTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricDistributionBoardTypeEnum NOTDEFINED = new IfcElectricDistributionBoardTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricFlowStorageDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricFlowStorageDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricFlowStorageDeviceTypeEnum BATTERY = new IfcElectricFlowStorageDeviceTypeEnum( "BATTERY" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum CAPACITORBANK = new IfcElectricFlowStorageDeviceTypeEnum( "CAPACITORBANK" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum HARMONICFILTER = new IfcElectricFlowStorageDeviceTypeEnum( "HARMONICFILTER" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum INDUCTORBANK = new IfcElectricFlowStorageDeviceTypeEnum( "INDUCTORBANK" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum UPS = new IfcElectricFlowStorageDeviceTypeEnum( "UPS" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum USERDEFINED = new IfcElectricFlowStorageDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricFlowStorageDeviceTypeEnum NOTDEFINED = new IfcElectricFlowStorageDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricGeneratorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricGeneratorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricGeneratorTypeEnum CHP = new IfcElectricGeneratorTypeEnum( "CHP" );
		public static readonly IfcElectricGeneratorTypeEnum ENGINEGENERATOR = new IfcElectricGeneratorTypeEnum( "ENGINEGENERATOR" );
		public static readonly IfcElectricGeneratorTypeEnum STANDALONE = new IfcElectricGeneratorTypeEnum( "STANDALONE" );
		public static readonly IfcElectricGeneratorTypeEnum USERDEFINED = new IfcElectricGeneratorTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricGeneratorTypeEnum NOTDEFINED = new IfcElectricGeneratorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricMotorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricMotorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricMotorTypeEnum DC = new IfcElectricMotorTypeEnum( "DC" );
		public static readonly IfcElectricMotorTypeEnum INDUCTION = new IfcElectricMotorTypeEnum( "INDUCTION" );
		public static readonly IfcElectricMotorTypeEnum POLYPHASE = new IfcElectricMotorTypeEnum( "POLYPHASE" );
		public static readonly IfcElectricMotorTypeEnum RELUCTANCESYNCHRONOUS = new IfcElectricMotorTypeEnum( "RELUCTANCESYNCHRONOUS" );
		public static readonly IfcElectricMotorTypeEnum SYNCHRONOUS = new IfcElectricMotorTypeEnum( "SYNCHRONOUS" );
		public static readonly IfcElectricMotorTypeEnum USERDEFINED = new IfcElectricMotorTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricMotorTypeEnum NOTDEFINED = new IfcElectricMotorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElectricTimeControlTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElectricTimeControlTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElectricTimeControlTypeEnum TIMECLOCK = new IfcElectricTimeControlTypeEnum( "TIMECLOCK" );
		public static readonly IfcElectricTimeControlTypeEnum TIMEDELAY = new IfcElectricTimeControlTypeEnum( "TIMEDELAY" );
		public static readonly IfcElectricTimeControlTypeEnum RELAY = new IfcElectricTimeControlTypeEnum( "RELAY" );
		public static readonly IfcElectricTimeControlTypeEnum USERDEFINED = new IfcElectricTimeControlTypeEnum( "USERDEFINED" );
		public static readonly IfcElectricTimeControlTypeEnum NOTDEFINED = new IfcElectricTimeControlTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElementAssemblyTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcElementAssemblyTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElementAssemblyTypeEnum ACCESSORY_ASSEMBLY = new IfcElementAssemblyTypeEnum( "ACCESSORY_ASSEMBLY" );
		public static readonly IfcElementAssemblyTypeEnum ARCH = new IfcElementAssemblyTypeEnum( "ARCH" );
		public static readonly IfcElementAssemblyTypeEnum BEAM_GRID = new IfcElementAssemblyTypeEnum( "BEAM_GRID" );
		public static readonly IfcElementAssemblyTypeEnum BRACED_FRAME = new IfcElementAssemblyTypeEnum( "BRACED_FRAME" );
		public static readonly IfcElementAssemblyTypeEnum GIRDER = new IfcElementAssemblyTypeEnum( "GIRDER" );
		public static readonly IfcElementAssemblyTypeEnum REINFORCEMENT_UNIT = new IfcElementAssemblyTypeEnum( "REINFORCEMENT_UNIT" );
		public static readonly IfcElementAssemblyTypeEnum RIGID_FRAME = new IfcElementAssemblyTypeEnum( "RIGID_FRAME" );
		public static readonly IfcElementAssemblyTypeEnum SLAB_FIELD = new IfcElementAssemblyTypeEnum( "SLAB_FIELD" );
		public static readonly IfcElementAssemblyTypeEnum TRUSS = new IfcElementAssemblyTypeEnum( "TRUSS" );
		public static readonly IfcElementAssemblyTypeEnum USERDEFINED = new IfcElementAssemblyTypeEnum( "USERDEFINED" );
		public static readonly IfcElementAssemblyTypeEnum NOTDEFINED = new IfcElementAssemblyTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcElementCompositionEnum : BaseType
	{
	private readonly string ename;
		private IfcElementCompositionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcElementCompositionEnum COMPLEX = new IfcElementCompositionEnum( "COMPLEX" );
		public static readonly IfcElementCompositionEnum ELEMENT = new IfcElementCompositionEnum( "ELEMENT" );
		public static readonly IfcElementCompositionEnum PARTIAL = new IfcElementCompositionEnum( "PARTIAL" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEngineTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcEngineTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEngineTypeEnum EXTERNALCOMBUSTION = new IfcEngineTypeEnum( "EXTERNALCOMBUSTION" );
		public static readonly IfcEngineTypeEnum INTERNALCOMBUSTION = new IfcEngineTypeEnum( "INTERNALCOMBUSTION" );
		public static readonly IfcEngineTypeEnum USERDEFINED = new IfcEngineTypeEnum( "USERDEFINED" );
		public static readonly IfcEngineTypeEnum NOTDEFINED = new IfcEngineTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEvaporativeCoolerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcEvaporativeCoolerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum DIRECTEVAPORATIVEAIRWASHER = new IfcEvaporativeCoolerTypeEnum( "DIRECTEVAPORATIVEAIRWASHER" );
		public static readonly IfcEvaporativeCoolerTypeEnum INDIRECTEVAPORATIVEPACKAGEAIRCOOLER = new IfcEvaporativeCoolerTypeEnum( "INDIRECTEVAPORATIVEPACKAGEAIRCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum INDIRECTEVAPORATIVEWETCOIL = new IfcEvaporativeCoolerTypeEnum( "INDIRECTEVAPORATIVEWETCOIL" );
		public static readonly IfcEvaporativeCoolerTypeEnum INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER = new IfcEvaporativeCoolerTypeEnum( "INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER" );
		public static readonly IfcEvaporativeCoolerTypeEnum INDIRECTDIRECTCOMBINATION = new IfcEvaporativeCoolerTypeEnum( "INDIRECTDIRECTCOMBINATION" );
		public static readonly IfcEvaporativeCoolerTypeEnum USERDEFINED = new IfcEvaporativeCoolerTypeEnum( "USERDEFINED" );
		public static readonly IfcEvaporativeCoolerTypeEnum NOTDEFINED = new IfcEvaporativeCoolerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEvaporatorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcEvaporatorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEvaporatorTypeEnum DIRECTEXPANSION = new IfcEvaporatorTypeEnum( "DIRECTEXPANSION" );
		public static readonly IfcEvaporatorTypeEnum DIRECTEXPANSIONSHELLANDTUBE = new IfcEvaporatorTypeEnum( "DIRECTEXPANSIONSHELLANDTUBE" );
		public static readonly IfcEvaporatorTypeEnum DIRECTEXPANSIONTUBEINTUBE = new IfcEvaporatorTypeEnum( "DIRECTEXPANSIONTUBEINTUBE" );
		public static readonly IfcEvaporatorTypeEnum DIRECTEXPANSIONBRAZEDPLATE = new IfcEvaporatorTypeEnum( "DIRECTEXPANSIONBRAZEDPLATE" );
		public static readonly IfcEvaporatorTypeEnum FLOODEDSHELLANDTUBE = new IfcEvaporatorTypeEnum( "FLOODEDSHELLANDTUBE" );
		public static readonly IfcEvaporatorTypeEnum SHELLANDCOIL = new IfcEvaporatorTypeEnum( "SHELLANDCOIL" );
		public static readonly IfcEvaporatorTypeEnum USERDEFINED = new IfcEvaporatorTypeEnum( "USERDEFINED" );
		public static readonly IfcEvaporatorTypeEnum NOTDEFINED = new IfcEvaporatorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEventTriggerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcEventTriggerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEventTriggerTypeEnum EVENTRULE = new IfcEventTriggerTypeEnum( "EVENTRULE" );
		public static readonly IfcEventTriggerTypeEnum EVENTMESSAGE = new IfcEventTriggerTypeEnum( "EVENTMESSAGE" );
		public static readonly IfcEventTriggerTypeEnum EVENTTIME = new IfcEventTriggerTypeEnum( "EVENTTIME" );
		public static readonly IfcEventTriggerTypeEnum EVENTCOMPLEX = new IfcEventTriggerTypeEnum( "EVENTCOMPLEX" );
		public static readonly IfcEventTriggerTypeEnum USERDEFINED = new IfcEventTriggerTypeEnum( "USERDEFINED" );
		public static readonly IfcEventTriggerTypeEnum NOTDEFINED = new IfcEventTriggerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcEventTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcEventTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcEventTypeEnum STARTEVENT = new IfcEventTypeEnum( "STARTEVENT" );
		public static readonly IfcEventTypeEnum ENDEVENT = new IfcEventTypeEnum( "ENDEVENT" );
		public static readonly IfcEventTypeEnum INTERMEDIATEEVENT = new IfcEventTypeEnum( "INTERMEDIATEEVENT" );
		public static readonly IfcEventTypeEnum USERDEFINED = new IfcEventTypeEnum( "USERDEFINED" );
		public static readonly IfcEventTypeEnum NOTDEFINED = new IfcEventTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcExternalSpatialElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcExternalSpatialElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcExternalSpatialElementTypeEnum EXTERNAL = new IfcExternalSpatialElementTypeEnum( "EXTERNAL" );
		public static readonly IfcExternalSpatialElementTypeEnum EXTERNAL_EARTH = new IfcExternalSpatialElementTypeEnum( "EXTERNAL_EARTH" );
		public static readonly IfcExternalSpatialElementTypeEnum EXTERNAL_WATER = new IfcExternalSpatialElementTypeEnum( "EXTERNAL_WATER" );
		public static readonly IfcExternalSpatialElementTypeEnum EXTERNAL_FIRE = new IfcExternalSpatialElementTypeEnum( "EXTERNAL_FIRE" );
		public static readonly IfcExternalSpatialElementTypeEnum USERDEFINED = new IfcExternalSpatialElementTypeEnum( "USERDEFINED" );
		public static readonly IfcExternalSpatialElementTypeEnum NOTDEFIEND = new IfcExternalSpatialElementTypeEnum( "NOTDEFIEND" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFanTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFanTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFanTypeEnum CENTRIFUGALFORWARDCURVED = new IfcFanTypeEnum( "CENTRIFUGALFORWARDCURVED" );
		public static readonly IfcFanTypeEnum CENTRIFUGALRADIAL = new IfcFanTypeEnum( "CENTRIFUGALRADIAL" );
		public static readonly IfcFanTypeEnum CENTRIFUGALBACKWARDINCLINEDCURVED = new IfcFanTypeEnum( "CENTRIFUGALBACKWARDINCLINEDCURVED" );
		public static readonly IfcFanTypeEnum CENTRIFUGALAIRFOIL = new IfcFanTypeEnum( "CENTRIFUGALAIRFOIL" );
		public static readonly IfcFanTypeEnum TUBEAXIAL = new IfcFanTypeEnum( "TUBEAXIAL" );
		public static readonly IfcFanTypeEnum VANEAXIAL = new IfcFanTypeEnum( "VANEAXIAL" );
		public static readonly IfcFanTypeEnum PROPELLORAXIAL = new IfcFanTypeEnum( "PROPELLORAXIAL" );
		public static readonly IfcFanTypeEnum USERDEFINED = new IfcFanTypeEnum( "USERDEFINED" );
		public static readonly IfcFanTypeEnum NOTDEFINED = new IfcFanTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFastenerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFastenerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFastenerTypeEnum GLUE = new IfcFastenerTypeEnum( "GLUE" );
		public static readonly IfcFastenerTypeEnum MORTAR = new IfcFastenerTypeEnum( "MORTAR" );
		public static readonly IfcFastenerTypeEnum WELD = new IfcFastenerTypeEnum( "WELD" );
		public static readonly IfcFastenerTypeEnum USERDEFINED = new IfcFastenerTypeEnum( "USERDEFINED" );
		public static readonly IfcFastenerTypeEnum NOTDEFINED = new IfcFastenerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFilterTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFilterTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFilterTypeEnum AIRPARTICLEFILTER = new IfcFilterTypeEnum( "AIRPARTICLEFILTER" );
		public static readonly IfcFilterTypeEnum COMPRESSEDAIRFILTER = new IfcFilterTypeEnum( "COMPRESSEDAIRFILTER" );
		public static readonly IfcFilterTypeEnum ODORFILTER = new IfcFilterTypeEnum( "ODORFILTER" );
		public static readonly IfcFilterTypeEnum OILFILTER = new IfcFilterTypeEnum( "OILFILTER" );
		public static readonly IfcFilterTypeEnum STRAINER = new IfcFilterTypeEnum( "STRAINER" );
		public static readonly IfcFilterTypeEnum WATERFILTER = new IfcFilterTypeEnum( "WATERFILTER" );
		public static readonly IfcFilterTypeEnum USERDEFINED = new IfcFilterTypeEnum( "USERDEFINED" );
		public static readonly IfcFilterTypeEnum NOTDEFINED = new IfcFilterTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFireSuppressionTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFireSuppressionTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFireSuppressionTerminalTypeEnum BREECHINGINLET = new IfcFireSuppressionTerminalTypeEnum( "BREECHINGINLET" );
		public static readonly IfcFireSuppressionTerminalTypeEnum FIREHYDRANT = new IfcFireSuppressionTerminalTypeEnum( "FIREHYDRANT" );
		public static readonly IfcFireSuppressionTerminalTypeEnum HOSEREEL = new IfcFireSuppressionTerminalTypeEnum( "HOSEREEL" );
		public static readonly IfcFireSuppressionTerminalTypeEnum SPRINKLER = new IfcFireSuppressionTerminalTypeEnum( "SPRINKLER" );
		public static readonly IfcFireSuppressionTerminalTypeEnum SPRINKLERDEFLECTOR = new IfcFireSuppressionTerminalTypeEnum( "SPRINKLERDEFLECTOR" );
		public static readonly IfcFireSuppressionTerminalTypeEnum USERDEFINED = new IfcFireSuppressionTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcFireSuppressionTerminalTypeEnum NOTDEFINED = new IfcFireSuppressionTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFlowDirectionEnum : BaseType
	{
	private readonly string ename;
		private IfcFlowDirectionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFlowDirectionEnum SOURCE = new IfcFlowDirectionEnum( "SOURCE" );
		public static readonly IfcFlowDirectionEnum SINK = new IfcFlowDirectionEnum( "SINK" );
		public static readonly IfcFlowDirectionEnum SOURCEANDSINK = new IfcFlowDirectionEnum( "SOURCEANDSINK" );
		public static readonly IfcFlowDirectionEnum NOTDEFINED = new IfcFlowDirectionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFlowInstrumentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFlowInstrumentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFlowInstrumentTypeEnum PRESSUREGAUGE = new IfcFlowInstrumentTypeEnum( "PRESSUREGAUGE" );
		public static readonly IfcFlowInstrumentTypeEnum THERMOMETER = new IfcFlowInstrumentTypeEnum( "THERMOMETER" );
		public static readonly IfcFlowInstrumentTypeEnum AMMETER = new IfcFlowInstrumentTypeEnum( "AMMETER" );
		public static readonly IfcFlowInstrumentTypeEnum FREQUENCYMETER = new IfcFlowInstrumentTypeEnum( "FREQUENCYMETER" );
		public static readonly IfcFlowInstrumentTypeEnum POWERFACTORMETER = new IfcFlowInstrumentTypeEnum( "POWERFACTORMETER" );
		public static readonly IfcFlowInstrumentTypeEnum PHASEANGLEMETER = new IfcFlowInstrumentTypeEnum( "PHASEANGLEMETER" );
		public static readonly IfcFlowInstrumentTypeEnum VOLTMETER_PEAK = new IfcFlowInstrumentTypeEnum( "VOLTMETER_PEAK" );
		public static readonly IfcFlowInstrumentTypeEnum VOLTMETER_RMS = new IfcFlowInstrumentTypeEnum( "VOLTMETER_RMS" );
		public static readonly IfcFlowInstrumentTypeEnum USERDEFINED = new IfcFlowInstrumentTypeEnum( "USERDEFINED" );
		public static readonly IfcFlowInstrumentTypeEnum NOTDEFINED = new IfcFlowInstrumentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFlowMeterTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFlowMeterTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFlowMeterTypeEnum ENERGYMETER = new IfcFlowMeterTypeEnum( "ENERGYMETER" );
		public static readonly IfcFlowMeterTypeEnum GASMETER = new IfcFlowMeterTypeEnum( "GASMETER" );
		public static readonly IfcFlowMeterTypeEnum OILMETER = new IfcFlowMeterTypeEnum( "OILMETER" );
		public static readonly IfcFlowMeterTypeEnum WATERMETER = new IfcFlowMeterTypeEnum( "WATERMETER" );
		public static readonly IfcFlowMeterTypeEnum USERDEFINED = new IfcFlowMeterTypeEnum( "USERDEFINED" );
		public static readonly IfcFlowMeterTypeEnum NOTDEFINED = new IfcFlowMeterTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFootingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFootingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFootingTypeEnum CAISSON_FOUNDATION = new IfcFootingTypeEnum( "CAISSON_FOUNDATION" );
		public static readonly IfcFootingTypeEnum FOOTING_BEAM = new IfcFootingTypeEnum( "FOOTING_BEAM" );
		public static readonly IfcFootingTypeEnum PAD_FOOTING = new IfcFootingTypeEnum( "PAD_FOOTING" );
		public static readonly IfcFootingTypeEnum PILE_CAP = new IfcFootingTypeEnum( "PILE_CAP" );
		public static readonly IfcFootingTypeEnum STRIP_FOOTING = new IfcFootingTypeEnum( "STRIP_FOOTING" );
		public static readonly IfcFootingTypeEnum USERDEFINED = new IfcFootingTypeEnum( "USERDEFINED" );
		public static readonly IfcFootingTypeEnum NOTDEFINED = new IfcFootingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcFurnitureTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcFurnitureTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcFurnitureTypeEnum CHAIR = new IfcFurnitureTypeEnum( "CHAIR" );
		public static readonly IfcFurnitureTypeEnum TABLE = new IfcFurnitureTypeEnum( "TABLE" );
		public static readonly IfcFurnitureTypeEnum DESK = new IfcFurnitureTypeEnum( "DESK" );
		public static readonly IfcFurnitureTypeEnum BED = new IfcFurnitureTypeEnum( "BED" );
		public static readonly IfcFurnitureTypeEnum FILECABINET = new IfcFurnitureTypeEnum( "FILECABINET" );
		public static readonly IfcFurnitureTypeEnum SHELF = new IfcFurnitureTypeEnum( "SHELF" );
		public static readonly IfcFurnitureTypeEnum SOFA = new IfcFurnitureTypeEnum( "SOFA" );
		public static readonly IfcFurnitureTypeEnum USERDEFINED = new IfcFurnitureTypeEnum( "USERDEFINED" );
		public static readonly IfcFurnitureTypeEnum NOTDEFINED = new IfcFurnitureTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcGeographicElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcGeographicElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcGeographicElementTypeEnum TERRAIN = new IfcGeographicElementTypeEnum( "TERRAIN" );
		public static readonly IfcGeographicElementTypeEnum USERDEFINED = new IfcGeographicElementTypeEnum( "USERDEFINED" );
		public static readonly IfcGeographicElementTypeEnum NOTDEFINED = new IfcGeographicElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcGeometricProjectionEnum : BaseType
	{
	private readonly string ename;
		private IfcGeometricProjectionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcGeometricProjectionEnum GRAPH_VIEW = new IfcGeometricProjectionEnum( "GRAPH_VIEW" );
		public static readonly IfcGeometricProjectionEnum SKETCH_VIEW = new IfcGeometricProjectionEnum( "SKETCH_VIEW" );
		public static readonly IfcGeometricProjectionEnum MODEL_VIEW = new IfcGeometricProjectionEnum( "MODEL_VIEW" );
		public static readonly IfcGeometricProjectionEnum PLAN_VIEW = new IfcGeometricProjectionEnum( "PLAN_VIEW" );
		public static readonly IfcGeometricProjectionEnum REFLECTED_PLAN_VIEW = new IfcGeometricProjectionEnum( "REFLECTED_PLAN_VIEW" );
		public static readonly IfcGeometricProjectionEnum SECTION_VIEW = new IfcGeometricProjectionEnum( "SECTION_VIEW" );
		public static readonly IfcGeometricProjectionEnum ELEVATION_VIEW = new IfcGeometricProjectionEnum( "ELEVATION_VIEW" );
		public static readonly IfcGeometricProjectionEnum USERDEFINED = new IfcGeometricProjectionEnum( "USERDEFINED" );
		public static readonly IfcGeometricProjectionEnum NOTDEFINED = new IfcGeometricProjectionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcGlobalOrLocalEnum : BaseType
	{
	private readonly string ename;
		private IfcGlobalOrLocalEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcGlobalOrLocalEnum GLOBAL_COORDS = new IfcGlobalOrLocalEnum( "GLOBAL_COORDS" );
		public static readonly IfcGlobalOrLocalEnum LOCAL_COORDS = new IfcGlobalOrLocalEnum( "LOCAL_COORDS" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcGridTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcGridTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcGridTypeEnum RECTANGULAR = new IfcGridTypeEnum( "RECTANGULAR" );
		public static readonly IfcGridTypeEnum RADIAL = new IfcGridTypeEnum( "RADIAL" );
		public static readonly IfcGridTypeEnum TRIANGULAR = new IfcGridTypeEnum( "TRIANGULAR" );
		public static readonly IfcGridTypeEnum IRREGULAR = new IfcGridTypeEnum( "IRREGULAR" );
		public static readonly IfcGridTypeEnum USERDEFINED = new IfcGridTypeEnum( "USERDEFINED" );
		public static readonly IfcGridTypeEnum NOTDEFINED = new IfcGridTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcHeatExchangerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcHeatExchangerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcHeatExchangerTypeEnum PLATE = new IfcHeatExchangerTypeEnum( "PLATE" );
		public static readonly IfcHeatExchangerTypeEnum SHELLANDTUBE = new IfcHeatExchangerTypeEnum( "SHELLANDTUBE" );
		public static readonly IfcHeatExchangerTypeEnum USERDEFINED = new IfcHeatExchangerTypeEnum( "USERDEFINED" );
		public static readonly IfcHeatExchangerTypeEnum NOTDEFINED = new IfcHeatExchangerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcHumidifierTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcHumidifierTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcHumidifierTypeEnum STEAMINJECTION = new IfcHumidifierTypeEnum( "STEAMINJECTION" );
		public static readonly IfcHumidifierTypeEnum ADIABATICAIRWASHER = new IfcHumidifierTypeEnum( "ADIABATICAIRWASHER" );
		public static readonly IfcHumidifierTypeEnum ADIABATICPAN = new IfcHumidifierTypeEnum( "ADIABATICPAN" );
		public static readonly IfcHumidifierTypeEnum ADIABATICWETTEDELEMENT = new IfcHumidifierTypeEnum( "ADIABATICWETTEDELEMENT" );
		public static readonly IfcHumidifierTypeEnum ADIABATICATOMIZING = new IfcHumidifierTypeEnum( "ADIABATICATOMIZING" );
		public static readonly IfcHumidifierTypeEnum ADIABATICULTRASONIC = new IfcHumidifierTypeEnum( "ADIABATICULTRASONIC" );
		public static readonly IfcHumidifierTypeEnum ADIABATICRIGIDMEDIA = new IfcHumidifierTypeEnum( "ADIABATICRIGIDMEDIA" );
		public static readonly IfcHumidifierTypeEnum ADIABATICCOMPRESSEDAIRNOZZLE = new IfcHumidifierTypeEnum( "ADIABATICCOMPRESSEDAIRNOZZLE" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDELECTRIC = new IfcHumidifierTypeEnum( "ASSISTEDELECTRIC" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDNATURALGAS = new IfcHumidifierTypeEnum( "ASSISTEDNATURALGAS" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDPROPANE = new IfcHumidifierTypeEnum( "ASSISTEDPROPANE" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDBUTANE = new IfcHumidifierTypeEnum( "ASSISTEDBUTANE" );
		public static readonly IfcHumidifierTypeEnum ASSISTEDSTEAM = new IfcHumidifierTypeEnum( "ASSISTEDSTEAM" );
		public static readonly IfcHumidifierTypeEnum USERDEFINED = new IfcHumidifierTypeEnum( "USERDEFINED" );
		public static readonly IfcHumidifierTypeEnum NOTDEFINED = new IfcHumidifierTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcInterceptorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcInterceptorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcInterceptorTypeEnum CYCLONIC = new IfcInterceptorTypeEnum( "CYCLONIC" );
		public static readonly IfcInterceptorTypeEnum GREASE = new IfcInterceptorTypeEnum( "GREASE" );
		public static readonly IfcInterceptorTypeEnum OIL = new IfcInterceptorTypeEnum( "OIL" );
		public static readonly IfcInterceptorTypeEnum PETROL = new IfcInterceptorTypeEnum( "PETROL" );
		public static readonly IfcInterceptorTypeEnum USERDEFINED = new IfcInterceptorTypeEnum( "USERDEFINED" );
		public static readonly IfcInterceptorTypeEnum NOTDEFINED = new IfcInterceptorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcInternalOrExternalEnum : BaseType
	{
	private readonly string ename;
		private IfcInternalOrExternalEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcInternalOrExternalEnum INTERNAL = new IfcInternalOrExternalEnum( "INTERNAL" );
		public static readonly IfcInternalOrExternalEnum EXTERNAL = new IfcInternalOrExternalEnum( "EXTERNAL" );
		public static readonly IfcInternalOrExternalEnum EXTERNAL_EARTH = new IfcInternalOrExternalEnum( "EXTERNAL_EARTH" );
		public static readonly IfcInternalOrExternalEnum EXTERNAL_WATER = new IfcInternalOrExternalEnum( "EXTERNAL_WATER" );
		public static readonly IfcInternalOrExternalEnum EXTERNAL_FIRE = new IfcInternalOrExternalEnum( "EXTERNAL_FIRE" );
		public static readonly IfcInternalOrExternalEnum NOTDEFINED = new IfcInternalOrExternalEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcInventoryTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcInventoryTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcInventoryTypeEnum ASSETINVENTORY = new IfcInventoryTypeEnum( "ASSETINVENTORY" );
		public static readonly IfcInventoryTypeEnum SPACEINVENTORY = new IfcInventoryTypeEnum( "SPACEINVENTORY" );
		public static readonly IfcInventoryTypeEnum FURNITUREINVENTORY = new IfcInventoryTypeEnum( "FURNITUREINVENTORY" );
		public static readonly IfcInventoryTypeEnum USERDEFINED = new IfcInventoryTypeEnum( "USERDEFINED" );
		public static readonly IfcInventoryTypeEnum NOTDEFINED = new IfcInventoryTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcJunctionBoxTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcJunctionBoxTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcJunctionBoxTypeEnum DATA = new IfcJunctionBoxTypeEnum( "DATA" );
		public static readonly IfcJunctionBoxTypeEnum POWER = new IfcJunctionBoxTypeEnum( "POWER" );
		public static readonly IfcJunctionBoxTypeEnum USERDEFINED = new IfcJunctionBoxTypeEnum( "USERDEFINED" );
		public static readonly IfcJunctionBoxTypeEnum NOTDEFINED = new IfcJunctionBoxTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcKnotType : BaseType
	{
	private readonly string ename;
		private IfcKnotType (string enumName)
		{ ename = enumName; }
		public static readonly IfcKnotType UNIFORM_KNOTS = new IfcKnotType( "UNIFORM_KNOTS" );
		public static readonly IfcKnotType QUASI_UNIFORM_KNOTS = new IfcKnotType( "QUASI_UNIFORM_KNOTS" );
		public static readonly IfcKnotType PIECEWISE_BEZIER_KNOTS = new IfcKnotType( "PIECEWISE_BEZIER_KNOTS" );
		public static readonly IfcKnotType UNSPECIFIED = new IfcKnotType( "UNSPECIFIED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLaborResourceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcLaborResourceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLaborResourceTypeEnum ADMINISTRATION = new IfcLaborResourceTypeEnum( "ADMINISTRATION" );
		public static readonly IfcLaborResourceTypeEnum CARPENTRY = new IfcLaborResourceTypeEnum( "CARPENTRY" );
		public static readonly IfcLaborResourceTypeEnum CLEANING = new IfcLaborResourceTypeEnum( "CLEANING" );
		public static readonly IfcLaborResourceTypeEnum CONCRETE = new IfcLaborResourceTypeEnum( "CONCRETE" );
		public static readonly IfcLaborResourceTypeEnum DRYWALL = new IfcLaborResourceTypeEnum( "DRYWALL" );
		public static readonly IfcLaborResourceTypeEnum ELECTRIC = new IfcLaborResourceTypeEnum( "ELECTRIC" );
		public static readonly IfcLaborResourceTypeEnum FINISHING = new IfcLaborResourceTypeEnum( "FINISHING" );
		public static readonly IfcLaborResourceTypeEnum FLOORING = new IfcLaborResourceTypeEnum( "FLOORING" );
		public static readonly IfcLaborResourceTypeEnum GENERAL = new IfcLaborResourceTypeEnum( "GENERAL" );
		public static readonly IfcLaborResourceTypeEnum HVAC = new IfcLaborResourceTypeEnum( "HVAC" );
		public static readonly IfcLaborResourceTypeEnum LANDSCAPING = new IfcLaborResourceTypeEnum( "LANDSCAPING" );
		public static readonly IfcLaborResourceTypeEnum MASONRY = new IfcLaborResourceTypeEnum( "MASONRY" );
		public static readonly IfcLaborResourceTypeEnum PAINTING = new IfcLaborResourceTypeEnum( "PAINTING" );
		public static readonly IfcLaborResourceTypeEnum PAVING = new IfcLaborResourceTypeEnum( "PAVING" );
		public static readonly IfcLaborResourceTypeEnum PLUMBING = new IfcLaborResourceTypeEnum( "PLUMBING" );
		public static readonly IfcLaborResourceTypeEnum ROOFING = new IfcLaborResourceTypeEnum( "ROOFING" );
		public static readonly IfcLaborResourceTypeEnum SITEGRADING = new IfcLaborResourceTypeEnum( "SITEGRADING" );
		public static readonly IfcLaborResourceTypeEnum STEELWORK = new IfcLaborResourceTypeEnum( "STEELWORK" );
		public static readonly IfcLaborResourceTypeEnum SURVEYING = new IfcLaborResourceTypeEnum( "SURVEYING" );
		public static readonly IfcLaborResourceTypeEnum USERDEFINED = new IfcLaborResourceTypeEnum( "USERDEFINED" );
		public static readonly IfcLaborResourceTypeEnum NOTDEFINED = new IfcLaborResourceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLampTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcLampTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLampTypeEnum COMPACTFLUORESCENT = new IfcLampTypeEnum( "COMPACTFLUORESCENT" );
		public static readonly IfcLampTypeEnum FLUORESCENT = new IfcLampTypeEnum( "FLUORESCENT" );
		public static readonly IfcLampTypeEnum HALOGEN = new IfcLampTypeEnum( "HALOGEN" );
		public static readonly IfcLampTypeEnum HIGHPRESSUREMERCURY = new IfcLampTypeEnum( "HIGHPRESSUREMERCURY" );
		public static readonly IfcLampTypeEnum HIGHPRESSURESODIUM = new IfcLampTypeEnum( "HIGHPRESSURESODIUM" );
		public static readonly IfcLampTypeEnum LED = new IfcLampTypeEnum( "LED" );
		public static readonly IfcLampTypeEnum METALHALIDE = new IfcLampTypeEnum( "METALHALIDE" );
		public static readonly IfcLampTypeEnum OLED = new IfcLampTypeEnum( "OLED" );
		public static readonly IfcLampTypeEnum TUNGSTENFILAMENT = new IfcLampTypeEnum( "TUNGSTENFILAMENT" );
		public static readonly IfcLampTypeEnum USERDEFINED = new IfcLampTypeEnum( "USERDEFINED" );
		public static readonly IfcLampTypeEnum NOTDEFINED = new IfcLampTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLayerSetDirectionEnum : BaseType
	{
	private readonly string ename;
		private IfcLayerSetDirectionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLayerSetDirectionEnum AXIS1 = new IfcLayerSetDirectionEnum( "AXIS1" );
		public static readonly IfcLayerSetDirectionEnum AXIS2 = new IfcLayerSetDirectionEnum( "AXIS2" );
		public static readonly IfcLayerSetDirectionEnum AXIS3 = new IfcLayerSetDirectionEnum( "AXIS3" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLightDistributionCurveEnum : BaseType
	{
	private readonly string ename;
		private IfcLightDistributionCurveEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLightDistributionCurveEnum TYPE_A = new IfcLightDistributionCurveEnum( "TYPE_A" );
		public static readonly IfcLightDistributionCurveEnum TYPE_B = new IfcLightDistributionCurveEnum( "TYPE_B" );
		public static readonly IfcLightDistributionCurveEnum TYPE_C = new IfcLightDistributionCurveEnum( "TYPE_C" );
		public static readonly IfcLightDistributionCurveEnum NOTDEFINED = new IfcLightDistributionCurveEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLightEmissionSourceEnum : BaseType
	{
	private readonly string ename;
		private IfcLightEmissionSourceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLightEmissionSourceEnum COMPACTFLUORESCENT = new IfcLightEmissionSourceEnum( "COMPACTFLUORESCENT" );
		public static readonly IfcLightEmissionSourceEnum FLUORESCENT = new IfcLightEmissionSourceEnum( "FLUORESCENT" );
		public static readonly IfcLightEmissionSourceEnum HIGHPRESSUREMERCURY = new IfcLightEmissionSourceEnum( "HIGHPRESSUREMERCURY" );
		public static readonly IfcLightEmissionSourceEnum HIGHPRESSURESODIUM = new IfcLightEmissionSourceEnum( "HIGHPRESSURESODIUM" );
		public static readonly IfcLightEmissionSourceEnum LIGHTEMITTINGDIODE = new IfcLightEmissionSourceEnum( "LIGHTEMITTINGDIODE" );
		public static readonly IfcLightEmissionSourceEnum LOWPRESSURESODIUM = new IfcLightEmissionSourceEnum( "LOWPRESSURESODIUM" );
		public static readonly IfcLightEmissionSourceEnum LOWVOLTAGEHALOGEN = new IfcLightEmissionSourceEnum( "LOWVOLTAGEHALOGEN" );
		public static readonly IfcLightEmissionSourceEnum MAINVOLTAGEHALOGEN = new IfcLightEmissionSourceEnum( "MAINVOLTAGEHALOGEN" );
		public static readonly IfcLightEmissionSourceEnum METALHALIDE = new IfcLightEmissionSourceEnum( "METALHALIDE" );
		public static readonly IfcLightEmissionSourceEnum TUNGSTENFILAMENT = new IfcLightEmissionSourceEnum( "TUNGSTENFILAMENT" );
		public static readonly IfcLightEmissionSourceEnum NOTDEFINED = new IfcLightEmissionSourceEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLightFixtureTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcLightFixtureTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLightFixtureTypeEnum POINTSOURCE = new IfcLightFixtureTypeEnum( "POINTSOURCE" );
		public static readonly IfcLightFixtureTypeEnum DIRECTIONSOURCE = new IfcLightFixtureTypeEnum( "DIRECTIONSOURCE" );
		public static readonly IfcLightFixtureTypeEnum SECURITYLIGHTING = new IfcLightFixtureTypeEnum( "SECURITYLIGHTING" );
		public static readonly IfcLightFixtureTypeEnum USERDEFINED = new IfcLightFixtureTypeEnum( "USERDEFINED" );
		public static readonly IfcLightFixtureTypeEnum NOTDEFINED = new IfcLightFixtureTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLoadGroupTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcLoadGroupTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLoadGroupTypeEnum LOAD_GROUP = new IfcLoadGroupTypeEnum( "LOAD_GROUP" );
		public static readonly IfcLoadGroupTypeEnum LOAD_CASE = new IfcLoadGroupTypeEnum( "LOAD_CASE" );
		public static readonly IfcLoadGroupTypeEnum LOAD_COMBINATION = new IfcLoadGroupTypeEnum( "LOAD_COMBINATION" );
		public static readonly IfcLoadGroupTypeEnum USERDEFINED = new IfcLoadGroupTypeEnum( "USERDEFINED" );
		public static readonly IfcLoadGroupTypeEnum NOTDEFINED = new IfcLoadGroupTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcLogicalOperatorEnum : BaseType
	{
	private readonly string ename;
		private IfcLogicalOperatorEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcLogicalOperatorEnum LOGICALAND = new IfcLogicalOperatorEnum( "LOGICALAND" );
		public static readonly IfcLogicalOperatorEnum LOGICALOR = new IfcLogicalOperatorEnum( "LOGICALOR" );
		public static readonly IfcLogicalOperatorEnum LOGICALXOR = new IfcLogicalOperatorEnum( "LOGICALXOR" );
		public static readonly IfcLogicalOperatorEnum LOGICALNOTAND = new IfcLogicalOperatorEnum( "LOGICALNOTAND" );
		public static readonly IfcLogicalOperatorEnum LOGICALNOTOR = new IfcLogicalOperatorEnum( "LOGICALNOTOR" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcMechanicalFastenerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcMechanicalFastenerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcMechanicalFastenerTypeEnum ANCHORBOLT = new IfcMechanicalFastenerTypeEnum( "ANCHORBOLT" );
		public static readonly IfcMechanicalFastenerTypeEnum BOLT = new IfcMechanicalFastenerTypeEnum( "BOLT" );
		public static readonly IfcMechanicalFastenerTypeEnum DOWEL = new IfcMechanicalFastenerTypeEnum( "DOWEL" );
		public static readonly IfcMechanicalFastenerTypeEnum NAIL = new IfcMechanicalFastenerTypeEnum( "NAIL" );
		public static readonly IfcMechanicalFastenerTypeEnum NAILPLATE = new IfcMechanicalFastenerTypeEnum( "NAILPLATE" );
		public static readonly IfcMechanicalFastenerTypeEnum RIVET = new IfcMechanicalFastenerTypeEnum( "RIVET" );
		public static readonly IfcMechanicalFastenerTypeEnum SCREW = new IfcMechanicalFastenerTypeEnum( "SCREW" );
		public static readonly IfcMechanicalFastenerTypeEnum SHEARCONNECTOR = new IfcMechanicalFastenerTypeEnum( "SHEARCONNECTOR" );
		public static readonly IfcMechanicalFastenerTypeEnum STAPLE = new IfcMechanicalFastenerTypeEnum( "STAPLE" );
		public static readonly IfcMechanicalFastenerTypeEnum STUDSHEARCONNECTOR = new IfcMechanicalFastenerTypeEnum( "STUDSHEARCONNECTOR" );
		public static readonly IfcMechanicalFastenerTypeEnum USERDEFINED = new IfcMechanicalFastenerTypeEnum( "USERDEFINED" );
		public static readonly IfcMechanicalFastenerTypeEnum NOTDEFINED = new IfcMechanicalFastenerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcMedicalDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcMedicalDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcMedicalDeviceTypeEnum AIRSTATION = new IfcMedicalDeviceTypeEnum( "AIRSTATION" );
		public static readonly IfcMedicalDeviceTypeEnum FEEDAIRUNIT = new IfcMedicalDeviceTypeEnum( "FEEDAIRUNIT" );
		public static readonly IfcMedicalDeviceTypeEnum OXYGENGENERATOR = new IfcMedicalDeviceTypeEnum( "OXYGENGENERATOR" );
		public static readonly IfcMedicalDeviceTypeEnum OXYGENPLANT = new IfcMedicalDeviceTypeEnum( "OXYGENPLANT" );
		public static readonly IfcMedicalDeviceTypeEnum VACUUMSTATION = new IfcMedicalDeviceTypeEnum( "VACUUMSTATION" );
		public static readonly IfcMedicalDeviceTypeEnum USERDEFINED = new IfcMedicalDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcMedicalDeviceTypeEnum NOTDEFINED = new IfcMedicalDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcMemberTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcMemberTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcMemberTypeEnum BRACE = new IfcMemberTypeEnum( "BRACE" );
		public static readonly IfcMemberTypeEnum CHORD = new IfcMemberTypeEnum( "CHORD" );
		public static readonly IfcMemberTypeEnum COLLAR = new IfcMemberTypeEnum( "COLLAR" );
		public static readonly IfcMemberTypeEnum MEMBER = new IfcMemberTypeEnum( "MEMBER" );
		public static readonly IfcMemberTypeEnum MULLION = new IfcMemberTypeEnum( "MULLION" );
		public static readonly IfcMemberTypeEnum PLATE = new IfcMemberTypeEnum( "PLATE" );
		public static readonly IfcMemberTypeEnum POST = new IfcMemberTypeEnum( "POST" );
		public static readonly IfcMemberTypeEnum PURLIN = new IfcMemberTypeEnum( "PURLIN" );
		public static readonly IfcMemberTypeEnum RAFTER = new IfcMemberTypeEnum( "RAFTER" );
		public static readonly IfcMemberTypeEnum STRINGER = new IfcMemberTypeEnum( "STRINGER" );
		public static readonly IfcMemberTypeEnum STRUT = new IfcMemberTypeEnum( "STRUT" );
		public static readonly IfcMemberTypeEnum STUD = new IfcMemberTypeEnum( "STUD" );
		public static readonly IfcMemberTypeEnum USERDEFINED = new IfcMemberTypeEnum( "USERDEFINED" );
		public static readonly IfcMemberTypeEnum NOTDEFINED = new IfcMemberTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcMotorConnectionTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcMotorConnectionTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcMotorConnectionTypeEnum BELTDRIVE = new IfcMotorConnectionTypeEnum( "BELTDRIVE" );
		public static readonly IfcMotorConnectionTypeEnum COUPLING = new IfcMotorConnectionTypeEnum( "COUPLING" );
		public static readonly IfcMotorConnectionTypeEnum DIRECTDRIVE = new IfcMotorConnectionTypeEnum( "DIRECTDRIVE" );
		public static readonly IfcMotorConnectionTypeEnum USERDEFINED = new IfcMotorConnectionTypeEnum( "USERDEFINED" );
		public static readonly IfcMotorConnectionTypeEnum NOTDEFINED = new IfcMotorConnectionTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcNullStyle : BaseType
	{
	private readonly string ename;
		private IfcNullStyle (string enumName)
		{ ename = enumName; }
		public static readonly IfcNullStyle NULL = new IfcNullStyle( "NULL" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcObjectTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcObjectTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcObjectTypeEnum PRODUCT = new IfcObjectTypeEnum( "PRODUCT" );
		public static readonly IfcObjectTypeEnum PROCESS = new IfcObjectTypeEnum( "PROCESS" );
		public static readonly IfcObjectTypeEnum CONTROL = new IfcObjectTypeEnum( "CONTROL" );
		public static readonly IfcObjectTypeEnum RESOURCE = new IfcObjectTypeEnum( "RESOURCE" );
		public static readonly IfcObjectTypeEnum ACTOR = new IfcObjectTypeEnum( "ACTOR" );
		public static readonly IfcObjectTypeEnum GROUP = new IfcObjectTypeEnum( "GROUP" );
		public static readonly IfcObjectTypeEnum PROJECT = new IfcObjectTypeEnum( "PROJECT" );
		public static readonly IfcObjectTypeEnum NOTDEFINED = new IfcObjectTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcObjectiveEnum : BaseType
	{
	private readonly string ename;
		private IfcObjectiveEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcObjectiveEnum CODECOMPLIANCE = new IfcObjectiveEnum( "CODECOMPLIANCE" );
		public static readonly IfcObjectiveEnum CODEWAIVER = new IfcObjectiveEnum( "CODEWAIVER" );
		public static readonly IfcObjectiveEnum DESIGNINTENT = new IfcObjectiveEnum( "DESIGNINTENT" );
		public static readonly IfcObjectiveEnum EXTERNAL = new IfcObjectiveEnum( "EXTERNAL" );
		public static readonly IfcObjectiveEnum HEALTHANDSAFETY = new IfcObjectiveEnum( "HEALTHANDSAFETY" );
		public static readonly IfcObjectiveEnum MERGECONFLICT = new IfcObjectiveEnum( "MERGECONFLICT" );
		public static readonly IfcObjectiveEnum MODELVIEW = new IfcObjectiveEnum( "MODELVIEW" );
		public static readonly IfcObjectiveEnum PARAMETER = new IfcObjectiveEnum( "PARAMETER" );
		public static readonly IfcObjectiveEnum REQUIREMENT = new IfcObjectiveEnum( "REQUIREMENT" );
		public static readonly IfcObjectiveEnum SPECIFICATION = new IfcObjectiveEnum( "SPECIFICATION" );
		public static readonly IfcObjectiveEnum TRIGGERCONDITION = new IfcObjectiveEnum( "TRIGGERCONDITION" );
		public static readonly IfcObjectiveEnum USERDEFINED = new IfcObjectiveEnum( "USERDEFINED" );
		public static readonly IfcObjectiveEnum NOTDEFINED = new IfcObjectiveEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcOccupantTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcOccupantTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcOccupantTypeEnum ASSIGNEE = new IfcOccupantTypeEnum( "ASSIGNEE" );
		public static readonly IfcOccupantTypeEnum ASSIGNOR = new IfcOccupantTypeEnum( "ASSIGNOR" );
		public static readonly IfcOccupantTypeEnum LESSEE = new IfcOccupantTypeEnum( "LESSEE" );
		public static readonly IfcOccupantTypeEnum LESSOR = new IfcOccupantTypeEnum( "LESSOR" );
		public static readonly IfcOccupantTypeEnum LETTINGAGENT = new IfcOccupantTypeEnum( "LETTINGAGENT" );
		public static readonly IfcOccupantTypeEnum OWNER = new IfcOccupantTypeEnum( "OWNER" );
		public static readonly IfcOccupantTypeEnum TENANT = new IfcOccupantTypeEnum( "TENANT" );
		public static readonly IfcOccupantTypeEnum USERDEFINED = new IfcOccupantTypeEnum( "USERDEFINED" );
		public static readonly IfcOccupantTypeEnum NOTDEFINED = new IfcOccupantTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcOpeningElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcOpeningElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcOpeningElementTypeEnum OPENING = new IfcOpeningElementTypeEnum( "OPENING" );
		public static readonly IfcOpeningElementTypeEnum RECESS = new IfcOpeningElementTypeEnum( "RECESS" );
		public static readonly IfcOpeningElementTypeEnum USERDEFINED = new IfcOpeningElementTypeEnum( "USERDEFINED" );
		public static readonly IfcOpeningElementTypeEnum NOTDEFINED = new IfcOpeningElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcOutletTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcOutletTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcOutletTypeEnum AUDIOVISUALOUTLET = new IfcOutletTypeEnum( "AUDIOVISUALOUTLET" );
		public static readonly IfcOutletTypeEnum COMMUNICATIONSOUTLET = new IfcOutletTypeEnum( "COMMUNICATIONSOUTLET" );
		public static readonly IfcOutletTypeEnum POWEROUTLET = new IfcOutletTypeEnum( "POWEROUTLET" );
		public static readonly IfcOutletTypeEnum DATAOUTLET = new IfcOutletTypeEnum( "DATAOUTLET" );
		public static readonly IfcOutletTypeEnum TELEPHONEOUTLET = new IfcOutletTypeEnum( "TELEPHONEOUTLET" );
		public static readonly IfcOutletTypeEnum USERDEFINED = new IfcOutletTypeEnum( "USERDEFINED" );
		public static readonly IfcOutletTypeEnum NOTDEFINED = new IfcOutletTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPerformanceHistoryTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPerformanceHistoryTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPerformanceHistoryTypeEnum USERDEFINED = new IfcPerformanceHistoryTypeEnum( "USERDEFINED" );
		public static readonly IfcPerformanceHistoryTypeEnum NOTDEFINED = new IfcPerformanceHistoryTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPermeableCoveringOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcPermeableCoveringOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPermeableCoveringOperationEnum GRILL = new IfcPermeableCoveringOperationEnum( "GRILL" );
		public static readonly IfcPermeableCoveringOperationEnum LOUVER = new IfcPermeableCoveringOperationEnum( "LOUVER" );
		public static readonly IfcPermeableCoveringOperationEnum SCREEN = new IfcPermeableCoveringOperationEnum( "SCREEN" );
		public static readonly IfcPermeableCoveringOperationEnum USERDEFINED = new IfcPermeableCoveringOperationEnum( "USERDEFINED" );
		public static readonly IfcPermeableCoveringOperationEnum NOTDEFINED = new IfcPermeableCoveringOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPermitTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPermitTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPermitTypeEnum ACCESS = new IfcPermitTypeEnum( "ACCESS" );
		public static readonly IfcPermitTypeEnum BUILDING = new IfcPermitTypeEnum( "BUILDING" );
		public static readonly IfcPermitTypeEnum WORK = new IfcPermitTypeEnum( "WORK" );
		public static readonly IfcPermitTypeEnum USERDEFINED = new IfcPermitTypeEnum( "USERDEFINED" );
		public static readonly IfcPermitTypeEnum NOTDEFINED = new IfcPermitTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPhysicalOrVirtualEnum : BaseType
	{
	private readonly string ename;
		private IfcPhysicalOrVirtualEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPhysicalOrVirtualEnum PHYSICAL = new IfcPhysicalOrVirtualEnum( "PHYSICAL" );
		public static readonly IfcPhysicalOrVirtualEnum VIRTUAL = new IfcPhysicalOrVirtualEnum( "VIRTUAL" );
		public static readonly IfcPhysicalOrVirtualEnum NOTDEFINED = new IfcPhysicalOrVirtualEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPileConstructionEnum : BaseType
	{
	private readonly string ename;
		private IfcPileConstructionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPileConstructionEnum CAST_IN_PLACE = new IfcPileConstructionEnum( "CAST_IN_PLACE" );
		public static readonly IfcPileConstructionEnum COMPOSITE = new IfcPileConstructionEnum( "COMPOSITE" );
		public static readonly IfcPileConstructionEnum PRECAST_CONCRETE = new IfcPileConstructionEnum( "PRECAST_CONCRETE" );
		public static readonly IfcPileConstructionEnum PREFAB_STEEL = new IfcPileConstructionEnum( "PREFAB_STEEL" );
		public static readonly IfcPileConstructionEnum USERDEFINED = new IfcPileConstructionEnum( "USERDEFINED" );
		public static readonly IfcPileConstructionEnum NOTDEFINED = new IfcPileConstructionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPileTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPileTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPileTypeEnum BORED = new IfcPileTypeEnum( "BORED" );
		public static readonly IfcPileTypeEnum DRIVEN = new IfcPileTypeEnum( "DRIVEN" );
		public static readonly IfcPileTypeEnum JETGROUTING = new IfcPileTypeEnum( "JETGROUTING" );
		public static readonly IfcPileTypeEnum COHESION = new IfcPileTypeEnum( "COHESION" );
		public static readonly IfcPileTypeEnum FRICTION = new IfcPileTypeEnum( "FRICTION" );
		public static readonly IfcPileTypeEnum SUPPORT = new IfcPileTypeEnum( "SUPPORT" );
		public static readonly IfcPileTypeEnum USERDEFINED = new IfcPileTypeEnum( "USERDEFINED" );
		public static readonly IfcPileTypeEnum NOTDEFINED = new IfcPileTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPipeFittingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPipeFittingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPipeFittingTypeEnum BEND = new IfcPipeFittingTypeEnum( "BEND" );
		public static readonly IfcPipeFittingTypeEnum CONNECTOR = new IfcPipeFittingTypeEnum( "CONNECTOR" );
		public static readonly IfcPipeFittingTypeEnum ENTRY = new IfcPipeFittingTypeEnum( "ENTRY" );
		public static readonly IfcPipeFittingTypeEnum EXIT = new IfcPipeFittingTypeEnum( "EXIT" );
		public static readonly IfcPipeFittingTypeEnum JUNCTION = new IfcPipeFittingTypeEnum( "JUNCTION" );
		public static readonly IfcPipeFittingTypeEnum OBSTRUCTION = new IfcPipeFittingTypeEnum( "OBSTRUCTION" );
		public static readonly IfcPipeFittingTypeEnum TRANSITION = new IfcPipeFittingTypeEnum( "TRANSITION" );
		public static readonly IfcPipeFittingTypeEnum USERDEFINED = new IfcPipeFittingTypeEnum( "USERDEFINED" );
		public static readonly IfcPipeFittingTypeEnum NOTDEFINED = new IfcPipeFittingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPipeSegmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPipeSegmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPipeSegmentTypeEnum CULVERT = new IfcPipeSegmentTypeEnum( "CULVERT" );
		public static readonly IfcPipeSegmentTypeEnum FLEXIBLESEGMENT = new IfcPipeSegmentTypeEnum( "FLEXIBLESEGMENT" );
		public static readonly IfcPipeSegmentTypeEnum RIGIDSEGMENT = new IfcPipeSegmentTypeEnum( "RIGIDSEGMENT" );
		public static readonly IfcPipeSegmentTypeEnum GUTTER = new IfcPipeSegmentTypeEnum( "GUTTER" );
		public static readonly IfcPipeSegmentTypeEnum SPOOL = new IfcPipeSegmentTypeEnum( "SPOOL" );
		public static readonly IfcPipeSegmentTypeEnum USERDEFINED = new IfcPipeSegmentTypeEnum( "USERDEFINED" );
		public static readonly IfcPipeSegmentTypeEnum NOTDEFINED = new IfcPipeSegmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPlateTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPlateTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPlateTypeEnum CURTAIN_PANEL = new IfcPlateTypeEnum( "CURTAIN_PANEL" );
		public static readonly IfcPlateTypeEnum SHEET = new IfcPlateTypeEnum( "SHEET" );
		public static readonly IfcPlateTypeEnum USERDEFINED = new IfcPlateTypeEnum( "USERDEFINED" );
		public static readonly IfcPlateTypeEnum NOTDEFINED = new IfcPlateTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProcedureTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProcedureTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProcedureTypeEnum ADVICE_CAUTION = new IfcProcedureTypeEnum( "ADVICE_CAUTION" );
		public static readonly IfcProcedureTypeEnum ADVICE_NOTE = new IfcProcedureTypeEnum( "ADVICE_NOTE" );
		public static readonly IfcProcedureTypeEnum ADVICE_WARNING = new IfcProcedureTypeEnum( "ADVICE_WARNING" );
		public static readonly IfcProcedureTypeEnum CALIBRATION = new IfcProcedureTypeEnum( "CALIBRATION" );
		public static readonly IfcProcedureTypeEnum DIAGNOSTIC = new IfcProcedureTypeEnum( "DIAGNOSTIC" );
		public static readonly IfcProcedureTypeEnum SHUTDOWN = new IfcProcedureTypeEnum( "SHUTDOWN" );
		public static readonly IfcProcedureTypeEnum STARTUP = new IfcProcedureTypeEnum( "STARTUP" );
		public static readonly IfcProcedureTypeEnum USERDEFINED = new IfcProcedureTypeEnum( "USERDEFINED" );
		public static readonly IfcProcedureTypeEnum NOTDEFINED = new IfcProcedureTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProfileTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProfileTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProfileTypeEnum CURVE = new IfcProfileTypeEnum( "CURVE" );
		public static readonly IfcProfileTypeEnum AREA = new IfcProfileTypeEnum( "AREA" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProjectOrderTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProjectOrderTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProjectOrderTypeEnum CHANGEORDER = new IfcProjectOrderTypeEnum( "CHANGEORDER" );
		public static readonly IfcProjectOrderTypeEnum MAINTENANCEWORKORDER = new IfcProjectOrderTypeEnum( "MAINTENANCEWORKORDER" );
		public static readonly IfcProjectOrderTypeEnum MOVEORDER = new IfcProjectOrderTypeEnum( "MOVEORDER" );
		public static readonly IfcProjectOrderTypeEnum PURCHASEORDER = new IfcProjectOrderTypeEnum( "PURCHASEORDER" );
		public static readonly IfcProjectOrderTypeEnum WORKORDER = new IfcProjectOrderTypeEnum( "WORKORDER" );
		public static readonly IfcProjectOrderTypeEnum USERDEFINED = new IfcProjectOrderTypeEnum( "USERDEFINED" );
		public static readonly IfcProjectOrderTypeEnum NOTDEFINED = new IfcProjectOrderTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProjectedOrTrueLengthEnum : BaseType
	{
	private readonly string ename;
		private IfcProjectedOrTrueLengthEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProjectedOrTrueLengthEnum PROJECTED_LENGTH = new IfcProjectedOrTrueLengthEnum( "PROJECTED_LENGTH" );
		public static readonly IfcProjectedOrTrueLengthEnum TRUE_LENGTH = new IfcProjectedOrTrueLengthEnum( "TRUE_LENGTH" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProjectionElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProjectionElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProjectionElementTypeEnum USERDEFINED = new IfcProjectionElementTypeEnum( "USERDEFINED" );
		public static readonly IfcProjectionElementTypeEnum NOTDEFINED = new IfcProjectionElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPropertySetTemplateTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPropertySetTemplateTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPropertySetTemplateTypeEnum PSET_TYPEDRIVENONLY = new IfcPropertySetTemplateTypeEnum( "PSET_TYPEDRIVENONLY" );
		public static readonly IfcPropertySetTemplateTypeEnum PSET_TYPEDRIVENOVERRIDE = new IfcPropertySetTemplateTypeEnum( "PSET_TYPEDRIVENOVERRIDE" );
		public static readonly IfcPropertySetTemplateTypeEnum PSET_OCCURRENCEDRIVEN = new IfcPropertySetTemplateTypeEnum( "PSET_OCCURRENCEDRIVEN" );
		public static readonly IfcPropertySetTemplateTypeEnum PSET_PERFORMANCEDRIVEN = new IfcPropertySetTemplateTypeEnum( "PSET_PERFORMANCEDRIVEN" );
		public static readonly IfcPropertySetTemplateTypeEnum QTO_TYPEDRIVENONLY = new IfcPropertySetTemplateTypeEnum( "QTO_TYPEDRIVENONLY" );
		public static readonly IfcPropertySetTemplateTypeEnum QTO_TYPEDRIVENOVERRIDE = new IfcPropertySetTemplateTypeEnum( "QTO_TYPEDRIVENOVERRIDE" );
		public static readonly IfcPropertySetTemplateTypeEnum QTO_OCCURRENCEDRIVEN = new IfcPropertySetTemplateTypeEnum( "QTO_OCCURRENCEDRIVEN" );
		public static readonly IfcPropertySetTemplateTypeEnum NOTDEFINED = new IfcPropertySetTemplateTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProtectiveDeviceTrippingUnitTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProtectiveDeviceTrippingUnitTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProtectiveDeviceTrippingUnitTypeEnum ELECTRONIC = new IfcProtectiveDeviceTrippingUnitTypeEnum( "ELECTRONIC" );
		public static readonly IfcProtectiveDeviceTrippingUnitTypeEnum ELECTROMAGNETIC = new IfcProtectiveDeviceTrippingUnitTypeEnum( "ELECTROMAGNETIC" );
		public static readonly IfcProtectiveDeviceTrippingUnitTypeEnum RESIDUALCURRENT = new IfcProtectiveDeviceTrippingUnitTypeEnum( "RESIDUALCURRENT" );
		public static readonly IfcProtectiveDeviceTrippingUnitTypeEnum THERMAL = new IfcProtectiveDeviceTrippingUnitTypeEnum( "THERMAL" );
		public static readonly IfcProtectiveDeviceTrippingUnitTypeEnum USERDEFINED = new IfcProtectiveDeviceTrippingUnitTypeEnum( "USERDEFINED" );
		public static readonly IfcProtectiveDeviceTrippingUnitTypeEnum NOTDEFINED = new IfcProtectiveDeviceTrippingUnitTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcProtectiveDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcProtectiveDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcProtectiveDeviceTypeEnum CIRCUITBREAKER = new IfcProtectiveDeviceTypeEnum( "CIRCUITBREAKER" );
		public static readonly IfcProtectiveDeviceTypeEnum EARTHLEAKAGECIRCUITBREAKER = new IfcProtectiveDeviceTypeEnum( "EARTHLEAKAGECIRCUITBREAKER" );
		public static readonly IfcProtectiveDeviceTypeEnum EARTHINGSWITCH = new IfcProtectiveDeviceTypeEnum( "EARTHINGSWITCH" );
		public static readonly IfcProtectiveDeviceTypeEnum FUSEDISCONNECTOR = new IfcProtectiveDeviceTypeEnum( "FUSEDISCONNECTOR" );
		public static readonly IfcProtectiveDeviceTypeEnum RESIDUALCURRENTCIRCUITBREAKER = new IfcProtectiveDeviceTypeEnum( "RESIDUALCURRENTCIRCUITBREAKER" );
		public static readonly IfcProtectiveDeviceTypeEnum RESIDUALCURRENTSWITCH = new IfcProtectiveDeviceTypeEnum( "RESIDUALCURRENTSWITCH" );
		public static readonly IfcProtectiveDeviceTypeEnum VARISTOR = new IfcProtectiveDeviceTypeEnum( "VARISTOR" );
		public static readonly IfcProtectiveDeviceTypeEnum USERDEFINED = new IfcProtectiveDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcProtectiveDeviceTypeEnum NOTDEFINED = new IfcProtectiveDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcPumpTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcPumpTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcPumpTypeEnum CIRCULATOR = new IfcPumpTypeEnum( "CIRCULATOR" );
		public static readonly IfcPumpTypeEnum ENDSUCTION = new IfcPumpTypeEnum( "ENDSUCTION" );
		public static readonly IfcPumpTypeEnum SPLITCASE = new IfcPumpTypeEnum( "SPLITCASE" );
		public static readonly IfcPumpTypeEnum SUBMERSIBLEPUMP = new IfcPumpTypeEnum( "SUBMERSIBLEPUMP" );
		public static readonly IfcPumpTypeEnum SUMPPUMP = new IfcPumpTypeEnum( "SUMPPUMP" );
		public static readonly IfcPumpTypeEnum VERTICALINLINE = new IfcPumpTypeEnum( "VERTICALINLINE" );
		public static readonly IfcPumpTypeEnum VERTICALTURBINE = new IfcPumpTypeEnum( "VERTICALTURBINE" );
		public static readonly IfcPumpTypeEnum USERDEFINED = new IfcPumpTypeEnum( "USERDEFINED" );
		public static readonly IfcPumpTypeEnum NOTDEFINED = new IfcPumpTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRailingTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRailingTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRailingTypeEnum HANDRAIL = new IfcRailingTypeEnum( "HANDRAIL" );
		public static readonly IfcRailingTypeEnum GUARDRAIL = new IfcRailingTypeEnum( "GUARDRAIL" );
		public static readonly IfcRailingTypeEnum BALUSTRADE = new IfcRailingTypeEnum( "BALUSTRADE" );
		public static readonly IfcRailingTypeEnum USERDEFINED = new IfcRailingTypeEnum( "USERDEFINED" );
		public static readonly IfcRailingTypeEnum NOTDEFINED = new IfcRailingTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRampFlightTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRampFlightTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRampFlightTypeEnum STRAIGHT = new IfcRampFlightTypeEnum( "STRAIGHT" );
		public static readonly IfcRampFlightTypeEnum SPIRAL = new IfcRampFlightTypeEnum( "SPIRAL" );
		public static readonly IfcRampFlightTypeEnum USERDEFINED = new IfcRampFlightTypeEnum( "USERDEFINED" );
		public static readonly IfcRampFlightTypeEnum NOTDEFINED = new IfcRampFlightTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRampTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRampTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRampTypeEnum STRAIGHT_RUN_RAMP = new IfcRampTypeEnum( "STRAIGHT_RUN_RAMP" );
		public static readonly IfcRampTypeEnum TWO_STRAIGHT_RUN_RAMP = new IfcRampTypeEnum( "TWO_STRAIGHT_RUN_RAMP" );
		public static readonly IfcRampTypeEnum QUARTER_TURN_RAMP = new IfcRampTypeEnum( "QUARTER_TURN_RAMP" );
		public static readonly IfcRampTypeEnum TWO_QUARTER_TURN_RAMP = new IfcRampTypeEnum( "TWO_QUARTER_TURN_RAMP" );
		public static readonly IfcRampTypeEnum HALF_TURN_RAMP = new IfcRampTypeEnum( "HALF_TURN_RAMP" );
		public static readonly IfcRampTypeEnum SPIRAL_RAMP = new IfcRampTypeEnum( "SPIRAL_RAMP" );
		public static readonly IfcRampTypeEnum USERDEFINED = new IfcRampTypeEnum( "USERDEFINED" );
		public static readonly IfcRampTypeEnum NOTDEFINED = new IfcRampTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRecurrenceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRecurrenceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRecurrenceTypeEnum DAILY = new IfcRecurrenceTypeEnum( "DAILY" );
		public static readonly IfcRecurrenceTypeEnum WEEKLY = new IfcRecurrenceTypeEnum( "WEEKLY" );
		public static readonly IfcRecurrenceTypeEnum MONTHLY_BY_DAY_OF_MONTH = new IfcRecurrenceTypeEnum( "MONTHLY_BY_DAY_OF_MONTH" );
		public static readonly IfcRecurrenceTypeEnum MONTHLY_BY_POSITION = new IfcRecurrenceTypeEnum( "MONTHLY_BY_POSITION" );
		public static readonly IfcRecurrenceTypeEnum BY_DAY_COUNT = new IfcRecurrenceTypeEnum( "BY_DAY_COUNT" );
		public static readonly IfcRecurrenceTypeEnum BY_WEEKDAY_COUNT = new IfcRecurrenceTypeEnum( "BY_WEEKDAY_COUNT" );
		public static readonly IfcRecurrenceTypeEnum YEARLY_BY_DAY_OF_MONTH = new IfcRecurrenceTypeEnum( "YEARLY_BY_DAY_OF_MONTH" );
		public static readonly IfcRecurrenceTypeEnum YEARLY_BY_POSITION = new IfcRecurrenceTypeEnum( "YEARLY_BY_POSITION" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcReflectanceMethodEnum : BaseType
	{
	private readonly string ename;
		private IfcReflectanceMethodEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcReflectanceMethodEnum BLINN = new IfcReflectanceMethodEnum( "BLINN" );
		public static readonly IfcReflectanceMethodEnum FLAT = new IfcReflectanceMethodEnum( "FLAT" );
		public static readonly IfcReflectanceMethodEnum GLASS = new IfcReflectanceMethodEnum( "GLASS" );
		public static readonly IfcReflectanceMethodEnum MATT = new IfcReflectanceMethodEnum( "MATT" );
		public static readonly IfcReflectanceMethodEnum METAL = new IfcReflectanceMethodEnum( "METAL" );
		public static readonly IfcReflectanceMethodEnum MIRROR = new IfcReflectanceMethodEnum( "MIRROR" );
		public static readonly IfcReflectanceMethodEnum PHONG = new IfcReflectanceMethodEnum( "PHONG" );
		public static readonly IfcReflectanceMethodEnum PLASTIC = new IfcReflectanceMethodEnum( "PLASTIC" );
		public static readonly IfcReflectanceMethodEnum STRAUSS = new IfcReflectanceMethodEnum( "STRAUSS" );
		public static readonly IfcReflectanceMethodEnum NOTDEFINED = new IfcReflectanceMethodEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcReinforcingBarRoleEnum : BaseType
	{
	private readonly string ename;
		private IfcReinforcingBarRoleEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcReinforcingBarRoleEnum MAIN = new IfcReinforcingBarRoleEnum( "MAIN" );
		public static readonly IfcReinforcingBarRoleEnum SHEAR = new IfcReinforcingBarRoleEnum( "SHEAR" );
		public static readonly IfcReinforcingBarRoleEnum LIGATURE = new IfcReinforcingBarRoleEnum( "LIGATURE" );
		public static readonly IfcReinforcingBarRoleEnum STUD = new IfcReinforcingBarRoleEnum( "STUD" );
		public static readonly IfcReinforcingBarRoleEnum PUNCHING = new IfcReinforcingBarRoleEnum( "PUNCHING" );
		public static readonly IfcReinforcingBarRoleEnum EDGE = new IfcReinforcingBarRoleEnum( "EDGE" );
		public static readonly IfcReinforcingBarRoleEnum RING = new IfcReinforcingBarRoleEnum( "RING" );
		public static readonly IfcReinforcingBarRoleEnum ANCHORING = new IfcReinforcingBarRoleEnum( "ANCHORING" );
		public static readonly IfcReinforcingBarRoleEnum USERDEFINED = new IfcReinforcingBarRoleEnum( "USERDEFINED" );
		public static readonly IfcReinforcingBarRoleEnum NOTDEFINED = new IfcReinforcingBarRoleEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcReinforcingBarSurfaceEnum : BaseType
	{
	private readonly string ename;
		private IfcReinforcingBarSurfaceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcReinforcingBarSurfaceEnum PLAIN = new IfcReinforcingBarSurfaceEnum( "PLAIN" );
		public static readonly IfcReinforcingBarSurfaceEnum TEXTURED = new IfcReinforcingBarSurfaceEnum( "TEXTURED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcReinforcingBarTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcReinforcingBarTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcReinforcingBarTypeEnum ANCHORING = new IfcReinforcingBarTypeEnum( "ANCHORING" );
		public static readonly IfcReinforcingBarTypeEnum EDGE = new IfcReinforcingBarTypeEnum( "EDGE" );
		public static readonly IfcReinforcingBarTypeEnum LIGATURE = new IfcReinforcingBarTypeEnum( "LIGATURE" );
		public static readonly IfcReinforcingBarTypeEnum MAIN = new IfcReinforcingBarTypeEnum( "MAIN" );
		public static readonly IfcReinforcingBarTypeEnum PUNCHING = new IfcReinforcingBarTypeEnum( "PUNCHING" );
		public static readonly IfcReinforcingBarTypeEnum RING = new IfcReinforcingBarTypeEnum( "RING" );
		public static readonly IfcReinforcingBarTypeEnum SHEAR = new IfcReinforcingBarTypeEnum( "SHEAR" );
		public static readonly IfcReinforcingBarTypeEnum STUD = new IfcReinforcingBarTypeEnum( "STUD" );
		public static readonly IfcReinforcingBarTypeEnum USERDEFINED = new IfcReinforcingBarTypeEnum( "USERDEFINED" );
		public static readonly IfcReinforcingBarTypeEnum NOTDEFINED = new IfcReinforcingBarTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcReinforcingMeshTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcReinforcingMeshTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcReinforcingMeshTypeEnum USERDEFINED = new IfcReinforcingMeshTypeEnum( "USERDEFINED" );
		public static readonly IfcReinforcingMeshTypeEnum NOTDEFINED = new IfcReinforcingMeshTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRoleEnum : BaseType
	{
	private readonly string ename;
		private IfcRoleEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRoleEnum SUPPLIER = new IfcRoleEnum( "SUPPLIER" );
		public static readonly IfcRoleEnum MANUFACTURER = new IfcRoleEnum( "MANUFACTURER" );
		public static readonly IfcRoleEnum CONTRACTOR = new IfcRoleEnum( "CONTRACTOR" );
		public static readonly IfcRoleEnum SUBCONTRACTOR = new IfcRoleEnum( "SUBCONTRACTOR" );
		public static readonly IfcRoleEnum ARCHITECT = new IfcRoleEnum( "ARCHITECT" );
		public static readonly IfcRoleEnum STRUCTURALENGINEER = new IfcRoleEnum( "STRUCTURALENGINEER" );
		public static readonly IfcRoleEnum COSTENGINEER = new IfcRoleEnum( "COSTENGINEER" );
		public static readonly IfcRoleEnum CLIENT = new IfcRoleEnum( "CLIENT" );
		public static readonly IfcRoleEnum BUILDINGOWNER = new IfcRoleEnum( "BUILDINGOWNER" );
		public static readonly IfcRoleEnum BUILDINGOPERATOR = new IfcRoleEnum( "BUILDINGOPERATOR" );
		public static readonly IfcRoleEnum MECHANICALENGINEER = new IfcRoleEnum( "MECHANICALENGINEER" );
		public static readonly IfcRoleEnum ELECTRICALENGINEER = new IfcRoleEnum( "ELECTRICALENGINEER" );
		public static readonly IfcRoleEnum PROJECTMANAGER = new IfcRoleEnum( "PROJECTMANAGER" );
		public static readonly IfcRoleEnum FACILITIESMANAGER = new IfcRoleEnum( "FACILITIESMANAGER" );
		public static readonly IfcRoleEnum CIVILENGINEER = new IfcRoleEnum( "CIVILENGINEER" );
		public static readonly IfcRoleEnum COMMISSIONINGENGINEER = new IfcRoleEnum( "COMMISSIONINGENGINEER" );
		public static readonly IfcRoleEnum ENGINEER = new IfcRoleEnum( "ENGINEER" );
		public static readonly IfcRoleEnum OWNER = new IfcRoleEnum( "OWNER" );
		public static readonly IfcRoleEnum CONSULTANT = new IfcRoleEnum( "CONSULTANT" );
		public static readonly IfcRoleEnum CONSTRUCTIONMANAGER = new IfcRoleEnum( "CONSTRUCTIONMANAGER" );
		public static readonly IfcRoleEnum FIELDCONSTRUCTIONMANAGER = new IfcRoleEnum( "FIELDCONSTRUCTIONMANAGER" );
		public static readonly IfcRoleEnum RESELLER = new IfcRoleEnum( "RESELLER" );
		public static readonly IfcRoleEnum USERDEFINED = new IfcRoleEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcRoofTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcRoofTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcRoofTypeEnum FLAT_ROOF = new IfcRoofTypeEnum( "FLAT_ROOF" );
		public static readonly IfcRoofTypeEnum SHED_ROOF = new IfcRoofTypeEnum( "SHED_ROOF" );
		public static readonly IfcRoofTypeEnum GABLE_ROOF = new IfcRoofTypeEnum( "GABLE_ROOF" );
		public static readonly IfcRoofTypeEnum HIP_ROOF = new IfcRoofTypeEnum( "HIP_ROOF" );
		public static readonly IfcRoofTypeEnum HIPPED_GABLE_ROOF = new IfcRoofTypeEnum( "HIPPED_GABLE_ROOF" );
		public static readonly IfcRoofTypeEnum GAMBREL_ROOF = new IfcRoofTypeEnum( "GAMBREL_ROOF" );
		public static readonly IfcRoofTypeEnum MANSARD_ROOF = new IfcRoofTypeEnum( "MANSARD_ROOF" );
		public static readonly IfcRoofTypeEnum BARREL_ROOF = new IfcRoofTypeEnum( "BARREL_ROOF" );
		public static readonly IfcRoofTypeEnum RAINBOW_ROOF = new IfcRoofTypeEnum( "RAINBOW_ROOF" );
		public static readonly IfcRoofTypeEnum BUTTERFLY_ROOF = new IfcRoofTypeEnum( "BUTTERFLY_ROOF" );
		public static readonly IfcRoofTypeEnum PAVILION_ROOF = new IfcRoofTypeEnum( "PAVILION_ROOF" );
		public static readonly IfcRoofTypeEnum DOME_ROOF = new IfcRoofTypeEnum( "DOME_ROOF" );
		public static readonly IfcRoofTypeEnum FREEFORM = new IfcRoofTypeEnum( "FREEFORM" );
		public static readonly IfcRoofTypeEnum USERDEFINED = new IfcRoofTypeEnum( "USERDEFINED" );
		public static readonly IfcRoofTypeEnum NOTDEFINED = new IfcRoofTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSIPrefix : BaseType
	{
	private readonly string ename;
		private IfcSIPrefix (string enumName)
		{ ename = enumName; }
		public static readonly IfcSIPrefix EXA = new IfcSIPrefix( "EXA" );
		public static readonly IfcSIPrefix PETA = new IfcSIPrefix( "PETA" );
		public static readonly IfcSIPrefix TERA = new IfcSIPrefix( "TERA" );
		public static readonly IfcSIPrefix GIGA = new IfcSIPrefix( "GIGA" );
		public static readonly IfcSIPrefix MEGA = new IfcSIPrefix( "MEGA" );
		public static readonly IfcSIPrefix KILO = new IfcSIPrefix( "KILO" );
		public static readonly IfcSIPrefix HECTO = new IfcSIPrefix( "HECTO" );
		public static readonly IfcSIPrefix DECA = new IfcSIPrefix( "DECA" );
		public static readonly IfcSIPrefix DECI = new IfcSIPrefix( "DECI" );
		public static readonly IfcSIPrefix CENTI = new IfcSIPrefix( "CENTI" );
		public static readonly IfcSIPrefix MILLI = new IfcSIPrefix( "MILLI" );
		public static readonly IfcSIPrefix MICRO = new IfcSIPrefix( "MICRO" );
		public static readonly IfcSIPrefix NANO = new IfcSIPrefix( "NANO" );
		public static readonly IfcSIPrefix PICO = new IfcSIPrefix( "PICO" );
		public static readonly IfcSIPrefix FEMTO = new IfcSIPrefix( "FEMTO" );
		public static readonly IfcSIPrefix ATTO = new IfcSIPrefix( "ATTO" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSIUnitName : BaseType
	{
	private readonly string ename;
		private IfcSIUnitName (string enumName)
		{ ename = enumName; }
		public static readonly IfcSIUnitName AMPERE = new IfcSIUnitName( "AMPERE" );
		public static readonly IfcSIUnitName BECQUEREL = new IfcSIUnitName( "BECQUEREL" );
		public static readonly IfcSIUnitName CANDELA = new IfcSIUnitName( "CANDELA" );
		public static readonly IfcSIUnitName COULOMB = new IfcSIUnitName( "COULOMB" );
		public static readonly IfcSIUnitName CUBIC_METRE = new IfcSIUnitName( "CUBIC_METRE" );
		public static readonly IfcSIUnitName DEGREE_CELSIUS = new IfcSIUnitName( "DEGREE_CELSIUS" );
		public static readonly IfcSIUnitName FARAD = new IfcSIUnitName( "FARAD" );
		public static readonly IfcSIUnitName GRAM = new IfcSIUnitName( "GRAM" );
		public static readonly IfcSIUnitName GRAY = new IfcSIUnitName( "GRAY" );
		public static readonly IfcSIUnitName HENRY = new IfcSIUnitName( "HENRY" );
		public static readonly IfcSIUnitName HERTZ = new IfcSIUnitName( "HERTZ" );
		public static readonly IfcSIUnitName JOULE = new IfcSIUnitName( "JOULE" );
		public static readonly IfcSIUnitName KELVIN = new IfcSIUnitName( "KELVIN" );
		public static readonly IfcSIUnitName LUMEN = new IfcSIUnitName( "LUMEN" );
		public static readonly IfcSIUnitName LUX = new IfcSIUnitName( "LUX" );
		public static readonly IfcSIUnitName METRE = new IfcSIUnitName( "METRE" );
		public static readonly IfcSIUnitName MOLE = new IfcSIUnitName( "MOLE" );
		public static readonly IfcSIUnitName NEWTON = new IfcSIUnitName( "NEWTON" );
		public static readonly IfcSIUnitName OHM = new IfcSIUnitName( "OHM" );
		public static readonly IfcSIUnitName PASCAL = new IfcSIUnitName( "PASCAL" );
		public static readonly IfcSIUnitName RADIAN = new IfcSIUnitName( "RADIAN" );
		public static readonly IfcSIUnitName SECOND = new IfcSIUnitName( "SECOND" );
		public static readonly IfcSIUnitName SIEMENS = new IfcSIUnitName( "SIEMENS" );
		public static readonly IfcSIUnitName SIEVERT = new IfcSIUnitName( "SIEVERT" );
		public static readonly IfcSIUnitName SQUARE_METRE = new IfcSIUnitName( "SQUARE_METRE" );
		public static readonly IfcSIUnitName STERADIAN = new IfcSIUnitName( "STERADIAN" );
		public static readonly IfcSIUnitName TESLA = new IfcSIUnitName( "TESLA" );
		public static readonly IfcSIUnitName VOLT = new IfcSIUnitName( "VOLT" );
		public static readonly IfcSIUnitName WATT = new IfcSIUnitName( "WATT" );
		public static readonly IfcSIUnitName WEBER = new IfcSIUnitName( "WEBER" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSanitaryTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSanitaryTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSanitaryTerminalTypeEnum BATH = new IfcSanitaryTerminalTypeEnum( "BATH" );
		public static readonly IfcSanitaryTerminalTypeEnum BIDET = new IfcSanitaryTerminalTypeEnum( "BIDET" );
		public static readonly IfcSanitaryTerminalTypeEnum CISTERN = new IfcSanitaryTerminalTypeEnum( "CISTERN" );
		public static readonly IfcSanitaryTerminalTypeEnum SHOWER = new IfcSanitaryTerminalTypeEnum( "SHOWER" );
		public static readonly IfcSanitaryTerminalTypeEnum SINK = new IfcSanitaryTerminalTypeEnum( "SINK" );
		public static readonly IfcSanitaryTerminalTypeEnum SANITARYFOUNTAIN = new IfcSanitaryTerminalTypeEnum( "SANITARYFOUNTAIN" );
		public static readonly IfcSanitaryTerminalTypeEnum TOILETPAN = new IfcSanitaryTerminalTypeEnum( "TOILETPAN" );
		public static readonly IfcSanitaryTerminalTypeEnum URINAL = new IfcSanitaryTerminalTypeEnum( "URINAL" );
		public static readonly IfcSanitaryTerminalTypeEnum WASHHANDBASIN = new IfcSanitaryTerminalTypeEnum( "WASHHANDBASIN" );
		public static readonly IfcSanitaryTerminalTypeEnum WCSEAT = new IfcSanitaryTerminalTypeEnum( "WCSEAT" );
		public static readonly IfcSanitaryTerminalTypeEnum USERDEFINED = new IfcSanitaryTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcSanitaryTerminalTypeEnum NOTDEFINED = new IfcSanitaryTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSectionTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSectionTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSectionTypeEnum UNIFORM = new IfcSectionTypeEnum( "UNIFORM" );
		public static readonly IfcSectionTypeEnum TAPERED = new IfcSectionTypeEnum( "TAPERED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSensorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSensorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSensorTypeEnum CONDUCTANCESENSOR = new IfcSensorTypeEnum( "CONDUCTANCESENSOR" );
		public static readonly IfcSensorTypeEnum CONTACTSENSOR = new IfcSensorTypeEnum( "CONTACTSENSOR" );
		public static readonly IfcSensorTypeEnum FIRESENSOR = new IfcSensorTypeEnum( "FIRESENSOR" );
		public static readonly IfcSensorTypeEnum FLOWSENSOR = new IfcSensorTypeEnum( "FLOWSENSOR" );
		public static readonly IfcSensorTypeEnum GASSENSOR = new IfcSensorTypeEnum( "GASSENSOR" );
		public static readonly IfcSensorTypeEnum HEATSENSOR = new IfcSensorTypeEnum( "HEATSENSOR" );
		public static readonly IfcSensorTypeEnum HUMIDITYSENSOR = new IfcSensorTypeEnum( "HUMIDITYSENSOR" );
		public static readonly IfcSensorTypeEnum IONCONCENTRATIONSENSOR = new IfcSensorTypeEnum( "IONCONCENTRATIONSENSOR" );
		public static readonly IfcSensorTypeEnum LEVELSENSOR = new IfcSensorTypeEnum( "LEVELSENSOR" );
		public static readonly IfcSensorTypeEnum LIGHTSENSOR = new IfcSensorTypeEnum( "LIGHTSENSOR" );
		public static readonly IfcSensorTypeEnum MOISTURESENSOR = new IfcSensorTypeEnum( "MOISTURESENSOR" );
		public static readonly IfcSensorTypeEnum MOVEMENTSENSOR = new IfcSensorTypeEnum( "MOVEMENTSENSOR" );
		public static readonly IfcSensorTypeEnum PHSENSOR = new IfcSensorTypeEnum( "PHSENSOR" );
		public static readonly IfcSensorTypeEnum PRESSURESENSOR = new IfcSensorTypeEnum( "PRESSURESENSOR" );
		public static readonly IfcSensorTypeEnum RADIATIONSENSOR = new IfcSensorTypeEnum( "RADIATIONSENSOR" );
		public static readonly IfcSensorTypeEnum RADIOACTIVITYSENSOR = new IfcSensorTypeEnum( "RADIOACTIVITYSENSOR" );
		public static readonly IfcSensorTypeEnum SMOKESENSOR = new IfcSensorTypeEnum( "SMOKESENSOR" );
		public static readonly IfcSensorTypeEnum SOUNDSENSOR = new IfcSensorTypeEnum( "SOUNDSENSOR" );
		public static readonly IfcSensorTypeEnum TEMPERATURESENSOR = new IfcSensorTypeEnum( "TEMPERATURESENSOR" );
		public static readonly IfcSensorTypeEnum WINDSENSOR = new IfcSensorTypeEnum( "WINDSENSOR" );
		public static readonly IfcSensorTypeEnum USERDEFINED = new IfcSensorTypeEnum( "USERDEFINED" );
		public static readonly IfcSensorTypeEnum NOTDEFINED = new IfcSensorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSequenceEnum : BaseType
	{
	private readonly string ename;
		private IfcSequenceEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSequenceEnum START_START = new IfcSequenceEnum( "START_START" );
		public static readonly IfcSequenceEnum START_FINISH = new IfcSequenceEnum( "START_FINISH" );
		public static readonly IfcSequenceEnum FINISH_START = new IfcSequenceEnum( "FINISH_START" );
		public static readonly IfcSequenceEnum FINISH_FINISH = new IfcSequenceEnum( "FINISH_FINISH" );
		public static readonly IfcSequenceEnum USERDEFINED = new IfcSequenceEnum( "USERDEFINED" );
		public static readonly IfcSequenceEnum NOTDEFINED = new IfcSequenceEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcShadingDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcShadingDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcShadingDeviceTypeEnum JALOUSIE = new IfcShadingDeviceTypeEnum( "JALOUSIE" );
		public static readonly IfcShadingDeviceTypeEnum SHUTTER = new IfcShadingDeviceTypeEnum( "SHUTTER" );
		public static readonly IfcShadingDeviceTypeEnum AWNING = new IfcShadingDeviceTypeEnum( "AWNING" );
		public static readonly IfcShadingDeviceTypeEnum USERDEFINED = new IfcShadingDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcShadingDeviceTypeEnum NOTDEFINED = new IfcShadingDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSimplePropertyTemplateTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSimplePropertyTemplateTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSimplePropertyTemplateTypeEnum P_SINGLEVALUE = new IfcSimplePropertyTemplateTypeEnum( "P_SINGLEVALUE" );
		public static readonly IfcSimplePropertyTemplateTypeEnum P_ENUMERATEDVALUE = new IfcSimplePropertyTemplateTypeEnum( "P_ENUMERATEDVALUE" );
		public static readonly IfcSimplePropertyTemplateTypeEnum P_BOUNDEDVALUE = new IfcSimplePropertyTemplateTypeEnum( "P_BOUNDEDVALUE" );
		public static readonly IfcSimplePropertyTemplateTypeEnum P_LISTVALUE = new IfcSimplePropertyTemplateTypeEnum( "P_LISTVALUE" );
		public static readonly IfcSimplePropertyTemplateTypeEnum P_TABLEVALUE = new IfcSimplePropertyTemplateTypeEnum( "P_TABLEVALUE" );
		public static readonly IfcSimplePropertyTemplateTypeEnum P_REFERENCEVALUE = new IfcSimplePropertyTemplateTypeEnum( "P_REFERENCEVALUE" );
		public static readonly IfcSimplePropertyTemplateTypeEnum Q_LENGTH = new IfcSimplePropertyTemplateTypeEnum( "Q_LENGTH" );
		public static readonly IfcSimplePropertyTemplateTypeEnum Q_AREA = new IfcSimplePropertyTemplateTypeEnum( "Q_AREA" );
		public static readonly IfcSimplePropertyTemplateTypeEnum Q_VOLUME = new IfcSimplePropertyTemplateTypeEnum( "Q_VOLUME" );
		public static readonly IfcSimplePropertyTemplateTypeEnum Q_COUNT = new IfcSimplePropertyTemplateTypeEnum( "Q_COUNT" );
		public static readonly IfcSimplePropertyTemplateTypeEnum Q_WEIGHT = new IfcSimplePropertyTemplateTypeEnum( "Q_WEIGHT" );
		public static readonly IfcSimplePropertyTemplateTypeEnum Q_TIME = new IfcSimplePropertyTemplateTypeEnum( "Q_TIME" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSlabTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSlabTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSlabTypeEnum FLOOR = new IfcSlabTypeEnum( "FLOOR" );
		public static readonly IfcSlabTypeEnum ROOF = new IfcSlabTypeEnum( "ROOF" );
		public static readonly IfcSlabTypeEnum LANDING = new IfcSlabTypeEnum( "LANDING" );
		public static readonly IfcSlabTypeEnum BASESLAB = new IfcSlabTypeEnum( "BASESLAB" );
		public static readonly IfcSlabTypeEnum USERDEFINED = new IfcSlabTypeEnum( "USERDEFINED" );
		public static readonly IfcSlabTypeEnum NOTDEFINED = new IfcSlabTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSolarDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSolarDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSolarDeviceTypeEnum SOLARCOLLECTOR = new IfcSolarDeviceTypeEnum( "SOLARCOLLECTOR" );
		public static readonly IfcSolarDeviceTypeEnum SOLARPANEL = new IfcSolarDeviceTypeEnum( "SOLARPANEL" );
		public static readonly IfcSolarDeviceTypeEnum USERDEFINED = new IfcSolarDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcSolarDeviceTypeEnum NOTDEFINED = new IfcSolarDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSpaceHeaterTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSpaceHeaterTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSpaceHeaterTypeEnum CONVECTOR = new IfcSpaceHeaterTypeEnum( "CONVECTOR" );
		public static readonly IfcSpaceHeaterTypeEnum RADIATOR = new IfcSpaceHeaterTypeEnum( "RADIATOR" );
		public static readonly IfcSpaceHeaterTypeEnum USERDEFINED = new IfcSpaceHeaterTypeEnum( "USERDEFINED" );
		public static readonly IfcSpaceHeaterTypeEnum NOTDEFINED = new IfcSpaceHeaterTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSpaceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSpaceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSpaceTypeEnum SPACE = new IfcSpaceTypeEnum( "SPACE" );
		public static readonly IfcSpaceTypeEnum PARKING = new IfcSpaceTypeEnum( "PARKING" );
		public static readonly IfcSpaceTypeEnum GFA = new IfcSpaceTypeEnum( "GFA" );
		public static readonly IfcSpaceTypeEnum INTERNAL = new IfcSpaceTypeEnum( "INTERNAL" );
		public static readonly IfcSpaceTypeEnum EXTERNAL = new IfcSpaceTypeEnum( "EXTERNAL" );
		public static readonly IfcSpaceTypeEnum USERDEFINED = new IfcSpaceTypeEnum( "USERDEFINED" );
		public static readonly IfcSpaceTypeEnum NOTDEFINED = new IfcSpaceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSpatialZoneTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSpatialZoneTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSpatialZoneTypeEnum CONSTRUCTION = new IfcSpatialZoneTypeEnum( "CONSTRUCTION" );
		public static readonly IfcSpatialZoneTypeEnum FIRESAFETY = new IfcSpatialZoneTypeEnum( "FIRESAFETY" );
		public static readonly IfcSpatialZoneTypeEnum LIGHTING = new IfcSpatialZoneTypeEnum( "LIGHTING" );
		public static readonly IfcSpatialZoneTypeEnum OCCUPANCY = new IfcSpatialZoneTypeEnum( "OCCUPANCY" );
		public static readonly IfcSpatialZoneTypeEnum SECURITY = new IfcSpatialZoneTypeEnum( "SECURITY" );
		public static readonly IfcSpatialZoneTypeEnum THERMAL = new IfcSpatialZoneTypeEnum( "THERMAL" );
		public static readonly IfcSpatialZoneTypeEnum TRANSPORT = new IfcSpatialZoneTypeEnum( "TRANSPORT" );
		public static readonly IfcSpatialZoneTypeEnum VENTILATION = new IfcSpatialZoneTypeEnum( "VENTILATION" );
		public static readonly IfcSpatialZoneTypeEnum USERDEFINED = new IfcSpatialZoneTypeEnum( "USERDEFINED" );
		public static readonly IfcSpatialZoneTypeEnum NOTDEFINED = new IfcSpatialZoneTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStackTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStackTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStackTerminalTypeEnum BIRDCAGE = new IfcStackTerminalTypeEnum( "BIRDCAGE" );
		public static readonly IfcStackTerminalTypeEnum COWL = new IfcStackTerminalTypeEnum( "COWL" );
		public static readonly IfcStackTerminalTypeEnum RAINWATERHOPPER = new IfcStackTerminalTypeEnum( "RAINWATERHOPPER" );
		public static readonly IfcStackTerminalTypeEnum USERDEFINED = new IfcStackTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcStackTerminalTypeEnum NOTDEFINED = new IfcStackTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStairFlightTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStairFlightTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStairFlightTypeEnum STRAIGHT = new IfcStairFlightTypeEnum( "STRAIGHT" );
		public static readonly IfcStairFlightTypeEnum WINDER = new IfcStairFlightTypeEnum( "WINDER" );
		public static readonly IfcStairFlightTypeEnum SPIRAL = new IfcStairFlightTypeEnum( "SPIRAL" );
		public static readonly IfcStairFlightTypeEnum CURVED = new IfcStairFlightTypeEnum( "CURVED" );
		public static readonly IfcStairFlightTypeEnum FREEFORM = new IfcStairFlightTypeEnum( "FREEFORM" );
		public static readonly IfcStairFlightTypeEnum USERDEFINED = new IfcStairFlightTypeEnum( "USERDEFINED" );
		public static readonly IfcStairFlightTypeEnum NOTDEFINED = new IfcStairFlightTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStairTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStairTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStairTypeEnum STRAIGHT_RUN_STAIR = new IfcStairTypeEnum( "STRAIGHT_RUN_STAIR" );
		public static readonly IfcStairTypeEnum TWO_STRAIGHT_RUN_STAIR = new IfcStairTypeEnum( "TWO_STRAIGHT_RUN_STAIR" );
		public static readonly IfcStairTypeEnum QUARTER_WINDING_STAIR = new IfcStairTypeEnum( "QUARTER_WINDING_STAIR" );
		public static readonly IfcStairTypeEnum QUARTER_TURN_STAIR = new IfcStairTypeEnum( "QUARTER_TURN_STAIR" );
		public static readonly IfcStairTypeEnum HALF_WINDING_STAIR = new IfcStairTypeEnum( "HALF_WINDING_STAIR" );
		public static readonly IfcStairTypeEnum HALF_TURN_STAIR = new IfcStairTypeEnum( "HALF_TURN_STAIR" );
		public static readonly IfcStairTypeEnum TWO_QUARTER_WINDING_STAIR = new IfcStairTypeEnum( "TWO_QUARTER_WINDING_STAIR" );
		public static readonly IfcStairTypeEnum TWO_QUARTER_TURN_STAIR = new IfcStairTypeEnum( "TWO_QUARTER_TURN_STAIR" );
		public static readonly IfcStairTypeEnum THREE_QUARTER_WINDING_STAIR = new IfcStairTypeEnum( "THREE_QUARTER_WINDING_STAIR" );
		public static readonly IfcStairTypeEnum THREE_QUARTER_TURN_STAIR = new IfcStairTypeEnum( "THREE_QUARTER_TURN_STAIR" );
		public static readonly IfcStairTypeEnum SPIRAL_STAIR = new IfcStairTypeEnum( "SPIRAL_STAIR" );
		public static readonly IfcStairTypeEnum DOUBLE_RETURN_STAIR = new IfcStairTypeEnum( "DOUBLE_RETURN_STAIR" );
		public static readonly IfcStairTypeEnum CURVED_RUN_STAIR = new IfcStairTypeEnum( "CURVED_RUN_STAIR" );
		public static readonly IfcStairTypeEnum TWO_CURVED_RUN_STAIR = new IfcStairTypeEnum( "TWO_CURVED_RUN_STAIR" );
		public static readonly IfcStairTypeEnum USERDEFINED = new IfcStairTypeEnum( "USERDEFINED" );
		public static readonly IfcStairTypeEnum NOTDEFINED = new IfcStairTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStateEnum : BaseType
	{
	private readonly string ename;
		private IfcStateEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStateEnum READWRITE = new IfcStateEnum( "READWRITE" );
		public static readonly IfcStateEnum READONLY = new IfcStateEnum( "READONLY" );
		public static readonly IfcStateEnum LOCKED = new IfcStateEnum( "LOCKED" );
		public static readonly IfcStateEnum READWRITELOCKED = new IfcStateEnum( "READWRITELOCKED" );
		public static readonly IfcStateEnum READONLYLOCKED = new IfcStateEnum( "READONLYLOCKED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStructuralCurveActivityTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStructuralCurveActivityTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStructuralCurveActivityTypeEnum CONST = new IfcStructuralCurveActivityTypeEnum( "CONST" );
		public static readonly IfcStructuralCurveActivityTypeEnum LINEAR = new IfcStructuralCurveActivityTypeEnum( "LINEAR" );
		public static readonly IfcStructuralCurveActivityTypeEnum POLYGONAL = new IfcStructuralCurveActivityTypeEnum( "POLYGONAL" );
		public static readonly IfcStructuralCurveActivityTypeEnum EQUIDISTANT = new IfcStructuralCurveActivityTypeEnum( "EQUIDISTANT" );
		public static readonly IfcStructuralCurveActivityTypeEnum SINUS = new IfcStructuralCurveActivityTypeEnum( "SINUS" );
		public static readonly IfcStructuralCurveActivityTypeEnum PARABOLA = new IfcStructuralCurveActivityTypeEnum( "PARABOLA" );
		public static readonly IfcStructuralCurveActivityTypeEnum DISCRETE = new IfcStructuralCurveActivityTypeEnum( "DISCRETE" );
		public static readonly IfcStructuralCurveActivityTypeEnum USERDEFINED = new IfcStructuralCurveActivityTypeEnum( "USERDEFINED" );
		public static readonly IfcStructuralCurveActivityTypeEnum NOTDEFINED = new IfcStructuralCurveActivityTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStructuralCurveMemberTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStructuralCurveMemberTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStructuralCurveMemberTypeEnum RIGID_JOINED_MEMBER = new IfcStructuralCurveMemberTypeEnum( "RIGID_JOINED_MEMBER" );
		public static readonly IfcStructuralCurveMemberTypeEnum PIN_JOINED_MEMBER = new IfcStructuralCurveMemberTypeEnum( "PIN_JOINED_MEMBER" );
		public static readonly IfcStructuralCurveMemberTypeEnum CABLE = new IfcStructuralCurveMemberTypeEnum( "CABLE" );
		public static readonly IfcStructuralCurveMemberTypeEnum TENSION_MEMBER = new IfcStructuralCurveMemberTypeEnum( "TENSION_MEMBER" );
		public static readonly IfcStructuralCurveMemberTypeEnum COMPRESSION_MEMBER = new IfcStructuralCurveMemberTypeEnum( "COMPRESSION_MEMBER" );
		public static readonly IfcStructuralCurveMemberTypeEnum USERDEFINED = new IfcStructuralCurveMemberTypeEnum( "USERDEFINED" );
		public static readonly IfcStructuralCurveMemberTypeEnum NOTDEFINED = new IfcStructuralCurveMemberTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStructuralSurfaceActivityTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStructuralSurfaceActivityTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStructuralSurfaceActivityTypeEnum CONST = new IfcStructuralSurfaceActivityTypeEnum( "CONST" );
		public static readonly IfcStructuralSurfaceActivityTypeEnum BILINEAR = new IfcStructuralSurfaceActivityTypeEnum( "BILINEAR" );
		public static readonly IfcStructuralSurfaceActivityTypeEnum DISCRETE = new IfcStructuralSurfaceActivityTypeEnum( "DISCRETE" );
		public static readonly IfcStructuralSurfaceActivityTypeEnum ISOCONTOUR = new IfcStructuralSurfaceActivityTypeEnum( "ISOCONTOUR" );
		public static readonly IfcStructuralSurfaceActivityTypeEnum USERDEFINED = new IfcStructuralSurfaceActivityTypeEnum( "USERDEFINED" );
		public static readonly IfcStructuralSurfaceActivityTypeEnum NOTDEFINED = new IfcStructuralSurfaceActivityTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcStructuralSurfaceMemberTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcStructuralSurfaceMemberTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcStructuralSurfaceMemberTypeEnum BENDING_ELEMENT = new IfcStructuralSurfaceMemberTypeEnum( "BENDING_ELEMENT" );
		public static readonly IfcStructuralSurfaceMemberTypeEnum MEMBRANE_ELEMENT = new IfcStructuralSurfaceMemberTypeEnum( "MEMBRANE_ELEMENT" );
		public static readonly IfcStructuralSurfaceMemberTypeEnum SHELL = new IfcStructuralSurfaceMemberTypeEnum( "SHELL" );
		public static readonly IfcStructuralSurfaceMemberTypeEnum USERDEFINED = new IfcStructuralSurfaceMemberTypeEnum( "USERDEFINED" );
		public static readonly IfcStructuralSurfaceMemberTypeEnum NOTDEFINED = new IfcStructuralSurfaceMemberTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSubContractResourceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSubContractResourceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSubContractResourceTypeEnum PURCHASE = new IfcSubContractResourceTypeEnum( "PURCHASE" );
		public static readonly IfcSubContractResourceTypeEnum WORK = new IfcSubContractResourceTypeEnum( "WORK" );
		public static readonly IfcSubContractResourceTypeEnum USERDEFINED = new IfcSubContractResourceTypeEnum( "USERDEFINED" );
		public static readonly IfcSubContractResourceTypeEnum NOTDEFINED = new IfcSubContractResourceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSurfaceFeatureTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSurfaceFeatureTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSurfaceFeatureTypeEnum MARK = new IfcSurfaceFeatureTypeEnum( "MARK" );
		public static readonly IfcSurfaceFeatureTypeEnum TAG = new IfcSurfaceFeatureTypeEnum( "TAG" );
		public static readonly IfcSurfaceFeatureTypeEnum TREATMENT = new IfcSurfaceFeatureTypeEnum( "TREATMENT" );
		public static readonly IfcSurfaceFeatureTypeEnum USERDEFINED = new IfcSurfaceFeatureTypeEnum( "USERDEFINED" );
		public static readonly IfcSurfaceFeatureTypeEnum NOTDEFINED = new IfcSurfaceFeatureTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSurfaceSide : BaseType
	{
	private readonly string ename;
		private IfcSurfaceSide (string enumName)
		{ ename = enumName; }
		public static readonly IfcSurfaceSide POSITIVE = new IfcSurfaceSide( "POSITIVE" );
		public static readonly IfcSurfaceSide NEGATIVE = new IfcSurfaceSide( "NEGATIVE" );
		public static readonly IfcSurfaceSide BOTH = new IfcSurfaceSide( "BOTH" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSwitchingDeviceTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSwitchingDeviceTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSwitchingDeviceTypeEnum CONTACTOR = new IfcSwitchingDeviceTypeEnum( "CONTACTOR" );
		public static readonly IfcSwitchingDeviceTypeEnum DIMMERSWITCH = new IfcSwitchingDeviceTypeEnum( "DIMMERSWITCH" );
		public static readonly IfcSwitchingDeviceTypeEnum EMERGENCYSTOP = new IfcSwitchingDeviceTypeEnum( "EMERGENCYSTOP" );
		public static readonly IfcSwitchingDeviceTypeEnum KEYPAD = new IfcSwitchingDeviceTypeEnum( "KEYPAD" );
		public static readonly IfcSwitchingDeviceTypeEnum MOMENTARYSWITCH = new IfcSwitchingDeviceTypeEnum( "MOMENTARYSWITCH" );
		public static readonly IfcSwitchingDeviceTypeEnum SELECTORSWITCH = new IfcSwitchingDeviceTypeEnum( "SELECTORSWITCH" );
		public static readonly IfcSwitchingDeviceTypeEnum STARTER = new IfcSwitchingDeviceTypeEnum( "STARTER" );
		public static readonly IfcSwitchingDeviceTypeEnum SWITCHDISCONNECTOR = new IfcSwitchingDeviceTypeEnum( "SWITCHDISCONNECTOR" );
		public static readonly IfcSwitchingDeviceTypeEnum TOGGLESWITCH = new IfcSwitchingDeviceTypeEnum( "TOGGLESWITCH" );
		public static readonly IfcSwitchingDeviceTypeEnum USERDEFINED = new IfcSwitchingDeviceTypeEnum( "USERDEFINED" );
		public static readonly IfcSwitchingDeviceTypeEnum NOTDEFINED = new IfcSwitchingDeviceTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcSystemFurnitureElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcSystemFurnitureElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcSystemFurnitureElementTypeEnum PANEL = new IfcSystemFurnitureElementTypeEnum( "PANEL" );
		public static readonly IfcSystemFurnitureElementTypeEnum WORKSURFACE = new IfcSystemFurnitureElementTypeEnum( "WORKSURFACE" );
		public static readonly IfcSystemFurnitureElementTypeEnum USERDEFINED = new IfcSystemFurnitureElementTypeEnum( "USERDEFINED" );
		public static readonly IfcSystemFurnitureElementTypeEnum NOTDEFINED = new IfcSystemFurnitureElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTankTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTankTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTankTypeEnum BASIN = new IfcTankTypeEnum( "BASIN" );
		public static readonly IfcTankTypeEnum BREAKPRESSURE = new IfcTankTypeEnum( "BREAKPRESSURE" );
		public static readonly IfcTankTypeEnum EXPANSION = new IfcTankTypeEnum( "EXPANSION" );
		public static readonly IfcTankTypeEnum FEEDANDEXPANSION = new IfcTankTypeEnum( "FEEDANDEXPANSION" );
		public static readonly IfcTankTypeEnum PRESSUREVESSEL = new IfcTankTypeEnum( "PRESSUREVESSEL" );
		public static readonly IfcTankTypeEnum STORAGE = new IfcTankTypeEnum( "STORAGE" );
		public static readonly IfcTankTypeEnum VESSEL = new IfcTankTypeEnum( "VESSEL" );
		public static readonly IfcTankTypeEnum USERDEFINED = new IfcTankTypeEnum( "USERDEFINED" );
		public static readonly IfcTankTypeEnum NOTDEFINED = new IfcTankTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTaskDurationEnum : BaseType
	{
	private readonly string ename;
		private IfcTaskDurationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTaskDurationEnum ELAPSEDTIME = new IfcTaskDurationEnum( "ELAPSEDTIME" );
		public static readonly IfcTaskDurationEnum WORKTIME = new IfcTaskDurationEnum( "WORKTIME" );
		public static readonly IfcTaskDurationEnum NOTDEFINED = new IfcTaskDurationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTaskTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTaskTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTaskTypeEnum ATTENDANCE = new IfcTaskTypeEnum( "ATTENDANCE" );
		public static readonly IfcTaskTypeEnum CONSTRUCTION = new IfcTaskTypeEnum( "CONSTRUCTION" );
		public static readonly IfcTaskTypeEnum DEMOLITION = new IfcTaskTypeEnum( "DEMOLITION" );
		public static readonly IfcTaskTypeEnum DISMANTLE = new IfcTaskTypeEnum( "DISMANTLE" );
		public static readonly IfcTaskTypeEnum DISPOSAL = new IfcTaskTypeEnum( "DISPOSAL" );
		public static readonly IfcTaskTypeEnum INSTALLATION = new IfcTaskTypeEnum( "INSTALLATION" );
		public static readonly IfcTaskTypeEnum LOGISTIC = new IfcTaskTypeEnum( "LOGISTIC" );
		public static readonly IfcTaskTypeEnum MAINTENANCE = new IfcTaskTypeEnum( "MAINTENANCE" );
		public static readonly IfcTaskTypeEnum MOVE = new IfcTaskTypeEnum( "MOVE" );
		public static readonly IfcTaskTypeEnum OPERATION = new IfcTaskTypeEnum( "OPERATION" );
		public static readonly IfcTaskTypeEnum REMOVAL = new IfcTaskTypeEnum( "REMOVAL" );
		public static readonly IfcTaskTypeEnum RENOVATION = new IfcTaskTypeEnum( "RENOVATION" );
		public static readonly IfcTaskTypeEnum USERDEFINED = new IfcTaskTypeEnum( "USERDEFINED" );
		public static readonly IfcTaskTypeEnum NOTDEFINED = new IfcTaskTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTendonAnchorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTendonAnchorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTendonAnchorTypeEnum COUPLER = new IfcTendonAnchorTypeEnum( "COUPLER" );
		public static readonly IfcTendonAnchorTypeEnum FIXED_END = new IfcTendonAnchorTypeEnum( "FIXED_END" );
		public static readonly IfcTendonAnchorTypeEnum TENSIONING_END = new IfcTendonAnchorTypeEnum( "TENSIONING_END" );
		public static readonly IfcTendonAnchorTypeEnum USERDEFINED = new IfcTendonAnchorTypeEnum( "USERDEFINED" );
		public static readonly IfcTendonAnchorTypeEnum NOTDEFINED = new IfcTendonAnchorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTendonTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTendonTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTendonTypeEnum BAR = new IfcTendonTypeEnum( "BAR" );
		public static readonly IfcTendonTypeEnum COATED = new IfcTendonTypeEnum( "COATED" );
		public static readonly IfcTendonTypeEnum STRAND = new IfcTendonTypeEnum( "STRAND" );
		public static readonly IfcTendonTypeEnum WIRE = new IfcTendonTypeEnum( "WIRE" );
		public static readonly IfcTendonTypeEnum USERDEFINED = new IfcTendonTypeEnum( "USERDEFINED" );
		public static readonly IfcTendonTypeEnum NOTDEFINED = new IfcTendonTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTextPath : BaseType
	{
	private readonly string ename;
		private IfcTextPath (string enumName)
		{ ename = enumName; }
		public static readonly IfcTextPath LEFT = new IfcTextPath( "LEFT" );
		public static readonly IfcTextPath RIGHT = new IfcTextPath( "RIGHT" );
		public static readonly IfcTextPath UP = new IfcTextPath( "UP" );
		public static readonly IfcTextPath DOWN = new IfcTextPath( "DOWN" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTimeSeriesDataTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTimeSeriesDataTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTimeSeriesDataTypeEnum CONTINUOUS = new IfcTimeSeriesDataTypeEnum( "CONTINUOUS" );
		public static readonly IfcTimeSeriesDataTypeEnum DISCRETE = new IfcTimeSeriesDataTypeEnum( "DISCRETE" );
		public static readonly IfcTimeSeriesDataTypeEnum DISCRETEBINARY = new IfcTimeSeriesDataTypeEnum( "DISCRETEBINARY" );
		public static readonly IfcTimeSeriesDataTypeEnum PIECEWISEBINARY = new IfcTimeSeriesDataTypeEnum( "PIECEWISEBINARY" );
		public static readonly IfcTimeSeriesDataTypeEnum PIECEWISECONSTANT = new IfcTimeSeriesDataTypeEnum( "PIECEWISECONSTANT" );
		public static readonly IfcTimeSeriesDataTypeEnum PIECEWISECONTINUOUS = new IfcTimeSeriesDataTypeEnum( "PIECEWISECONTINUOUS" );
		public static readonly IfcTimeSeriesDataTypeEnum NOTDEFINED = new IfcTimeSeriesDataTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTransformerTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTransformerTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTransformerTypeEnum CURRENT = new IfcTransformerTypeEnum( "CURRENT" );
		public static readonly IfcTransformerTypeEnum FREQUENCY = new IfcTransformerTypeEnum( "FREQUENCY" );
		public static readonly IfcTransformerTypeEnum INVERTER = new IfcTransformerTypeEnum( "INVERTER" );
		public static readonly IfcTransformerTypeEnum RECTIFIER = new IfcTransformerTypeEnum( "RECTIFIER" );
		public static readonly IfcTransformerTypeEnum VOLTAGE = new IfcTransformerTypeEnum( "VOLTAGE" );
		public static readonly IfcTransformerTypeEnum USERDEFINED = new IfcTransformerTypeEnum( "USERDEFINED" );
		public static readonly IfcTransformerTypeEnum NOTDEFINED = new IfcTransformerTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTransitionCode : BaseType
	{
	private readonly string ename;
		private IfcTransitionCode (string enumName)
		{ ename = enumName; }
		public static readonly IfcTransitionCode DISCONTINUOUS = new IfcTransitionCode( "DISCONTINUOUS" );
		public static readonly IfcTransitionCode CONTINUOUS = new IfcTransitionCode( "CONTINUOUS" );
		public static readonly IfcTransitionCode CONTSAMEGRADIENT = new IfcTransitionCode( "CONTSAMEGRADIENT" );
		public static readonly IfcTransitionCode CONTSAMEGRADIENTSAMECURVATURE = new IfcTransitionCode( "CONTSAMEGRADIENTSAMECURVATURE" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTransportElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTransportElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTransportElementTypeEnum ELEVATOR = new IfcTransportElementTypeEnum( "ELEVATOR" );
		public static readonly IfcTransportElementTypeEnum ESCALATOR = new IfcTransportElementTypeEnum( "ESCALATOR" );
		public static readonly IfcTransportElementTypeEnum MOVINGWALKWAY = new IfcTransportElementTypeEnum( "MOVINGWALKWAY" );
		public static readonly IfcTransportElementTypeEnum CRANEWAY = new IfcTransportElementTypeEnum( "CRANEWAY" );
		public static readonly IfcTransportElementTypeEnum LIFTINGGEAR = new IfcTransportElementTypeEnum( "LIFTINGGEAR" );
		public static readonly IfcTransportElementTypeEnum USERDEFINED = new IfcTransportElementTypeEnum( "USERDEFINED" );
		public static readonly IfcTransportElementTypeEnum NOTDEFINED = new IfcTransportElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTrimmingPreference : BaseType
	{
	private readonly string ename;
		private IfcTrimmingPreference (string enumName)
		{ ename = enumName; }
		public static readonly IfcTrimmingPreference CARTESIAN = new IfcTrimmingPreference( "CARTESIAN" );
		public static readonly IfcTrimmingPreference PARAMETER = new IfcTrimmingPreference( "PARAMETER" );
		public static readonly IfcTrimmingPreference UNSPECIFIED = new IfcTrimmingPreference( "UNSPECIFIED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcTubeBundleTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcTubeBundleTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcTubeBundleTypeEnum FINNED = new IfcTubeBundleTypeEnum( "FINNED" );
		public static readonly IfcTubeBundleTypeEnum USERDEFINED = new IfcTubeBundleTypeEnum( "USERDEFINED" );
		public static readonly IfcTubeBundleTypeEnum NOTDEFINED = new IfcTubeBundleTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcUnitEnum : BaseType
	{
	private readonly string ename;
		private IfcUnitEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcUnitEnum ABSORBEDDOSEUNIT = new IfcUnitEnum( "ABSORBEDDOSEUNIT" );
		public static readonly IfcUnitEnum AMOUNTOFSUBSTANCEUNIT = new IfcUnitEnum( "AMOUNTOFSUBSTANCEUNIT" );
		public static readonly IfcUnitEnum AREAUNIT = new IfcUnitEnum( "AREAUNIT" );
		public static readonly IfcUnitEnum DOSEEQUIVALENTUNIT = new IfcUnitEnum( "DOSEEQUIVALENTUNIT" );
		public static readonly IfcUnitEnum ELECTRICCAPACITANCEUNIT = new IfcUnitEnum( "ELECTRICCAPACITANCEUNIT" );
		public static readonly IfcUnitEnum ELECTRICCHARGEUNIT = new IfcUnitEnum( "ELECTRICCHARGEUNIT" );
		public static readonly IfcUnitEnum ELECTRICCONDUCTANCEUNIT = new IfcUnitEnum( "ELECTRICCONDUCTANCEUNIT" );
		public static readonly IfcUnitEnum ELECTRICCURRENTUNIT = new IfcUnitEnum( "ELECTRICCURRENTUNIT" );
		public static readonly IfcUnitEnum ELECTRICRESISTANCEUNIT = new IfcUnitEnum( "ELECTRICRESISTANCEUNIT" );
		public static readonly IfcUnitEnum ELECTRICVOLTAGEUNIT = new IfcUnitEnum( "ELECTRICVOLTAGEUNIT" );
		public static readonly IfcUnitEnum ENERGYUNIT = new IfcUnitEnum( "ENERGYUNIT" );
		public static readonly IfcUnitEnum FORCEUNIT = new IfcUnitEnum( "FORCEUNIT" );
		public static readonly IfcUnitEnum FREQUENCYUNIT = new IfcUnitEnum( "FREQUENCYUNIT" );
		public static readonly IfcUnitEnum ILLUMINANCEUNIT = new IfcUnitEnum( "ILLUMINANCEUNIT" );
		public static readonly IfcUnitEnum INDUCTANCEUNIT = new IfcUnitEnum( "INDUCTANCEUNIT" );
		public static readonly IfcUnitEnum LENGTHUNIT = new IfcUnitEnum( "LENGTHUNIT" );
		public static readonly IfcUnitEnum LUMINOUSFLUXUNIT = new IfcUnitEnum( "LUMINOUSFLUXUNIT" );
		public static readonly IfcUnitEnum LUMINOUSINTENSITYUNIT = new IfcUnitEnum( "LUMINOUSINTENSITYUNIT" );
		public static readonly IfcUnitEnum MAGNETICFLUXDENSITYUNIT = new IfcUnitEnum( "MAGNETICFLUXDENSITYUNIT" );
		public static readonly IfcUnitEnum MAGNETICFLUXUNIT = new IfcUnitEnum( "MAGNETICFLUXUNIT" );
		public static readonly IfcUnitEnum MASSUNIT = new IfcUnitEnum( "MASSUNIT" );
		public static readonly IfcUnitEnum PLANEANGLEUNIT = new IfcUnitEnum( "PLANEANGLEUNIT" );
		public static readonly IfcUnitEnum POWERUNIT = new IfcUnitEnum( "POWERUNIT" );
		public static readonly IfcUnitEnum PRESSUREUNIT = new IfcUnitEnum( "PRESSUREUNIT" );
		public static readonly IfcUnitEnum RADIOACTIVITYUNIT = new IfcUnitEnum( "RADIOACTIVITYUNIT" );
		public static readonly IfcUnitEnum SOLIDANGLEUNIT = new IfcUnitEnum( "SOLIDANGLEUNIT" );
		public static readonly IfcUnitEnum THERMODYNAMICTEMPERATUREUNIT = new IfcUnitEnum( "THERMODYNAMICTEMPERATUREUNIT" );
		public static readonly IfcUnitEnum TIMEUNIT = new IfcUnitEnum( "TIMEUNIT" );
		public static readonly IfcUnitEnum VOLUMEUNIT = new IfcUnitEnum( "VOLUMEUNIT" );
		public static readonly IfcUnitEnum USERDEFINED = new IfcUnitEnum( "USERDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcUnitaryControlElementTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcUnitaryControlElementTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcUnitaryControlElementTypeEnum ALARMPANEL = new IfcUnitaryControlElementTypeEnum( "ALARMPANEL" );
		public static readonly IfcUnitaryControlElementTypeEnum CONTROLPANEL = new IfcUnitaryControlElementTypeEnum( "CONTROLPANEL" );
		public static readonly IfcUnitaryControlElementTypeEnum GASDETECTIONPANEL = new IfcUnitaryControlElementTypeEnum( "GASDETECTIONPANEL" );
		public static readonly IfcUnitaryControlElementTypeEnum INDICATORPANEL = new IfcUnitaryControlElementTypeEnum( "INDICATORPANEL" );
		public static readonly IfcUnitaryControlElementTypeEnum MIMICPANEL = new IfcUnitaryControlElementTypeEnum( "MIMICPANEL" );
		public static readonly IfcUnitaryControlElementTypeEnum HUMIDISTAT = new IfcUnitaryControlElementTypeEnum( "HUMIDISTAT" );
		public static readonly IfcUnitaryControlElementTypeEnum THERMOSTAT = new IfcUnitaryControlElementTypeEnum( "THERMOSTAT" );
		public static readonly IfcUnitaryControlElementTypeEnum WEATHERSTATION = new IfcUnitaryControlElementTypeEnum( "WEATHERSTATION" );
		public static readonly IfcUnitaryControlElementTypeEnum USERDEFINED = new IfcUnitaryControlElementTypeEnum( "USERDEFINED" );
		public static readonly IfcUnitaryControlElementTypeEnum NOTDEFINED = new IfcUnitaryControlElementTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcUnitaryEquipmentTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcUnitaryEquipmentTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcUnitaryEquipmentTypeEnum AIRHANDLER = new IfcUnitaryEquipmentTypeEnum( "AIRHANDLER" );
		public static readonly IfcUnitaryEquipmentTypeEnum AIRCONDITIONINGUNIT = new IfcUnitaryEquipmentTypeEnum( "AIRCONDITIONINGUNIT" );
		public static readonly IfcUnitaryEquipmentTypeEnum DEHUMIDIFIER = new IfcUnitaryEquipmentTypeEnum( "DEHUMIDIFIER" );
		public static readonly IfcUnitaryEquipmentTypeEnum SPLITSYSTEM = new IfcUnitaryEquipmentTypeEnum( "SPLITSYSTEM" );
		public static readonly IfcUnitaryEquipmentTypeEnum ROOFTOPUNIT = new IfcUnitaryEquipmentTypeEnum( "ROOFTOPUNIT" );
		public static readonly IfcUnitaryEquipmentTypeEnum USERDEFINED = new IfcUnitaryEquipmentTypeEnum( "USERDEFINED" );
		public static readonly IfcUnitaryEquipmentTypeEnum NOTDEFINED = new IfcUnitaryEquipmentTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcValveTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcValveTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcValveTypeEnum AIRRELEASE = new IfcValveTypeEnum( "AIRRELEASE" );
		public static readonly IfcValveTypeEnum ANTIVACUUM = new IfcValveTypeEnum( "ANTIVACUUM" );
		public static readonly IfcValveTypeEnum CHANGEOVER = new IfcValveTypeEnum( "CHANGEOVER" );
		public static readonly IfcValveTypeEnum CHECK = new IfcValveTypeEnum( "CHECK" );
		public static readonly IfcValveTypeEnum COMMISSIONING = new IfcValveTypeEnum( "COMMISSIONING" );
		public static readonly IfcValveTypeEnum DIVERTING = new IfcValveTypeEnum( "DIVERTING" );
		public static readonly IfcValveTypeEnum DRAWOFFCOCK = new IfcValveTypeEnum( "DRAWOFFCOCK" );
		public static readonly IfcValveTypeEnum DOUBLECHECK = new IfcValveTypeEnum( "DOUBLECHECK" );
		public static readonly IfcValveTypeEnum DOUBLEREGULATING = new IfcValveTypeEnum( "DOUBLEREGULATING" );
		public static readonly IfcValveTypeEnum FAUCET = new IfcValveTypeEnum( "FAUCET" );
		public static readonly IfcValveTypeEnum FLUSHING = new IfcValveTypeEnum( "FLUSHING" );
		public static readonly IfcValveTypeEnum GASCOCK = new IfcValveTypeEnum( "GASCOCK" );
		public static readonly IfcValveTypeEnum GASTAP = new IfcValveTypeEnum( "GASTAP" );
		public static readonly IfcValveTypeEnum ISOLATING = new IfcValveTypeEnum( "ISOLATING" );
		public static readonly IfcValveTypeEnum MIXING = new IfcValveTypeEnum( "MIXING" );
		public static readonly IfcValveTypeEnum PRESSUREREDUCING = new IfcValveTypeEnum( "PRESSUREREDUCING" );
		public static readonly IfcValveTypeEnum PRESSURERELIEF = new IfcValveTypeEnum( "PRESSURERELIEF" );
		public static readonly IfcValveTypeEnum REGULATING = new IfcValveTypeEnum( "REGULATING" );
		public static readonly IfcValveTypeEnum SAFETYCUTOFF = new IfcValveTypeEnum( "SAFETYCUTOFF" );
		public static readonly IfcValveTypeEnum STEAMTRAP = new IfcValveTypeEnum( "STEAMTRAP" );
		public static readonly IfcValveTypeEnum STOPCOCK = new IfcValveTypeEnum( "STOPCOCK" );
		public static readonly IfcValveTypeEnum USERDEFINED = new IfcValveTypeEnum( "USERDEFINED" );
		public static readonly IfcValveTypeEnum NOTDEFINED = new IfcValveTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcVibrationIsolatorTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcVibrationIsolatorTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcVibrationIsolatorTypeEnum COMPRESSION = new IfcVibrationIsolatorTypeEnum( "COMPRESSION" );
		public static readonly IfcVibrationIsolatorTypeEnum SPRING = new IfcVibrationIsolatorTypeEnum( "SPRING" );
		public static readonly IfcVibrationIsolatorTypeEnum USERDEFINED = new IfcVibrationIsolatorTypeEnum( "USERDEFINED" );
		public static readonly IfcVibrationIsolatorTypeEnum NOTDEFINED = new IfcVibrationIsolatorTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcVoidingFeatureTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcVoidingFeatureTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcVoidingFeatureTypeEnum CUTOUT = new IfcVoidingFeatureTypeEnum( "CUTOUT" );
		public static readonly IfcVoidingFeatureTypeEnum NOTCH = new IfcVoidingFeatureTypeEnum( "NOTCH" );
		public static readonly IfcVoidingFeatureTypeEnum HOLE = new IfcVoidingFeatureTypeEnum( "HOLE" );
		public static readonly IfcVoidingFeatureTypeEnum MITER = new IfcVoidingFeatureTypeEnum( "MITER" );
		public static readonly IfcVoidingFeatureTypeEnum CHAMFER = new IfcVoidingFeatureTypeEnum( "CHAMFER" );
		public static readonly IfcVoidingFeatureTypeEnum EDGE = new IfcVoidingFeatureTypeEnum( "EDGE" );
		public static readonly IfcVoidingFeatureTypeEnum USERDEFINED = new IfcVoidingFeatureTypeEnum( "USERDEFINED" );
		public static readonly IfcVoidingFeatureTypeEnum NOTDEFINED = new IfcVoidingFeatureTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWallTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWallTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWallTypeEnum MOVABLE = new IfcWallTypeEnum( "MOVABLE" );
		public static readonly IfcWallTypeEnum PARAPET = new IfcWallTypeEnum( "PARAPET" );
		public static readonly IfcWallTypeEnum PARTITIONING = new IfcWallTypeEnum( "PARTITIONING" );
		public static readonly IfcWallTypeEnum PLUMBINGWALL = new IfcWallTypeEnum( "PLUMBINGWALL" );
		public static readonly IfcWallTypeEnum SHEAR = new IfcWallTypeEnum( "SHEAR" );
		public static readonly IfcWallTypeEnum SOLIDWALL = new IfcWallTypeEnum( "SOLIDWALL" );
		public static readonly IfcWallTypeEnum STANDARD = new IfcWallTypeEnum( "STANDARD" );
		public static readonly IfcWallTypeEnum POLYGONAL = new IfcWallTypeEnum( "POLYGONAL" );
		public static readonly IfcWallTypeEnum ELEMENTEDWALL = new IfcWallTypeEnum( "ELEMENTEDWALL" );
		public static readonly IfcWallTypeEnum USERDEFINED = new IfcWallTypeEnum( "USERDEFINED" );
		public static readonly IfcWallTypeEnum NOTDEFINED = new IfcWallTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWasteTerminalTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWasteTerminalTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWasteTerminalTypeEnum FLOORTRAP = new IfcWasteTerminalTypeEnum( "FLOORTRAP" );
		public static readonly IfcWasteTerminalTypeEnum FLOORWASTE = new IfcWasteTerminalTypeEnum( "FLOORWASTE" );
		public static readonly IfcWasteTerminalTypeEnum GULLYSUMP = new IfcWasteTerminalTypeEnum( "GULLYSUMP" );
		public static readonly IfcWasteTerminalTypeEnum GULLYTRAP = new IfcWasteTerminalTypeEnum( "GULLYTRAP" );
		public static readonly IfcWasteTerminalTypeEnum ROOFDRAIN = new IfcWasteTerminalTypeEnum( "ROOFDRAIN" );
		public static readonly IfcWasteTerminalTypeEnum WASTEDISPOSALUNIT = new IfcWasteTerminalTypeEnum( "WASTEDISPOSALUNIT" );
		public static readonly IfcWasteTerminalTypeEnum WASTETRAP = new IfcWasteTerminalTypeEnum( "WASTETRAP" );
		public static readonly IfcWasteTerminalTypeEnum USERDEFINED = new IfcWasteTerminalTypeEnum( "USERDEFINED" );
		public static readonly IfcWasteTerminalTypeEnum NOTDEFINED = new IfcWasteTerminalTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowPanelOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowPanelOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowPanelOperationEnum SIDEHUNGRIGHTHAND = new IfcWindowPanelOperationEnum( "SIDEHUNGRIGHTHAND" );
		public static readonly IfcWindowPanelOperationEnum SIDEHUNGLEFTHAND = new IfcWindowPanelOperationEnum( "SIDEHUNGLEFTHAND" );
		public static readonly IfcWindowPanelOperationEnum TILTANDTURNRIGHTHAND = new IfcWindowPanelOperationEnum( "TILTANDTURNRIGHTHAND" );
		public static readonly IfcWindowPanelOperationEnum TILTANDTURNLEFTHAND = new IfcWindowPanelOperationEnum( "TILTANDTURNLEFTHAND" );
		public static readonly IfcWindowPanelOperationEnum TOPHUNG = new IfcWindowPanelOperationEnum( "TOPHUNG" );
		public static readonly IfcWindowPanelOperationEnum BOTTOMHUNG = new IfcWindowPanelOperationEnum( "BOTTOMHUNG" );
		public static readonly IfcWindowPanelOperationEnum PIVOTHORIZONTAL = new IfcWindowPanelOperationEnum( "PIVOTHORIZONTAL" );
		public static readonly IfcWindowPanelOperationEnum PIVOTVERTICAL = new IfcWindowPanelOperationEnum( "PIVOTVERTICAL" );
		public static readonly IfcWindowPanelOperationEnum SLIDINGHORIZONTAL = new IfcWindowPanelOperationEnum( "SLIDINGHORIZONTAL" );
		public static readonly IfcWindowPanelOperationEnum SLIDINGVERTICAL = new IfcWindowPanelOperationEnum( "SLIDINGVERTICAL" );
		public static readonly IfcWindowPanelOperationEnum REMOVABLECASEMENT = new IfcWindowPanelOperationEnum( "REMOVABLECASEMENT" );
		public static readonly IfcWindowPanelOperationEnum FIXEDCASEMENT = new IfcWindowPanelOperationEnum( "FIXEDCASEMENT" );
		public static readonly IfcWindowPanelOperationEnum OTHEROPERATION = new IfcWindowPanelOperationEnum( "OTHEROPERATION" );
		public static readonly IfcWindowPanelOperationEnum NOTDEFINED = new IfcWindowPanelOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowPanelPositionEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowPanelPositionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowPanelPositionEnum LEFT = new IfcWindowPanelPositionEnum( "LEFT" );
		public static readonly IfcWindowPanelPositionEnum MIDDLE = new IfcWindowPanelPositionEnum( "MIDDLE" );
		public static readonly IfcWindowPanelPositionEnum RIGHT = new IfcWindowPanelPositionEnum( "RIGHT" );
		public static readonly IfcWindowPanelPositionEnum BOTTOM = new IfcWindowPanelPositionEnum( "BOTTOM" );
		public static readonly IfcWindowPanelPositionEnum TOP = new IfcWindowPanelPositionEnum( "TOP" );
		public static readonly IfcWindowPanelPositionEnum NOTDEFINED = new IfcWindowPanelPositionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowStyleConstructionEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowStyleConstructionEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowStyleConstructionEnum ALUMINIUM = new IfcWindowStyleConstructionEnum( "ALUMINIUM" );
		public static readonly IfcWindowStyleConstructionEnum HIGH_GRADE_STEEL = new IfcWindowStyleConstructionEnum( "HIGH_GRADE_STEEL" );
		public static readonly IfcWindowStyleConstructionEnum STEEL = new IfcWindowStyleConstructionEnum( "STEEL" );
		public static readonly IfcWindowStyleConstructionEnum WOOD = new IfcWindowStyleConstructionEnum( "WOOD" );
		public static readonly IfcWindowStyleConstructionEnum ALUMINIUM_WOOD = new IfcWindowStyleConstructionEnum( "ALUMINIUM_WOOD" );
		public static readonly IfcWindowStyleConstructionEnum PLASTIC = new IfcWindowStyleConstructionEnum( "PLASTIC" );
		public static readonly IfcWindowStyleConstructionEnum OTHER_CONSTRUCTION = new IfcWindowStyleConstructionEnum( "OTHER_CONSTRUCTION" );
		public static readonly IfcWindowStyleConstructionEnum NOTDEFINED = new IfcWindowStyleConstructionEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowStyleOperationEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowStyleOperationEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowStyleOperationEnum SINGLE_PANEL = new IfcWindowStyleOperationEnum( "SINGLE_PANEL" );
		public static readonly IfcWindowStyleOperationEnum DOUBLE_PANEL_VERTICAL = new IfcWindowStyleOperationEnum( "DOUBLE_PANEL_VERTICAL" );
		public static readonly IfcWindowStyleOperationEnum DOUBLE_PANEL_HORIZONTAL = new IfcWindowStyleOperationEnum( "DOUBLE_PANEL_HORIZONTAL" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_VERTICAL = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_VERTICAL" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_BOTTOM = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_BOTTOM" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_TOP = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_TOP" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_LEFT = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_LEFT" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_RIGHT = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_RIGHT" );
		public static readonly IfcWindowStyleOperationEnum TRIPLE_PANEL_HORIZONTAL = new IfcWindowStyleOperationEnum( "TRIPLE_PANEL_HORIZONTAL" );
		public static readonly IfcWindowStyleOperationEnum USERDEFINED = new IfcWindowStyleOperationEnum( "USERDEFINED" );
		public static readonly IfcWindowStyleOperationEnum NOTDEFINED = new IfcWindowStyleOperationEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowTypeEnum WINDOW = new IfcWindowTypeEnum( "WINDOW" );
		public static readonly IfcWindowTypeEnum SKYLIGHT = new IfcWindowTypeEnum( "SKYLIGHT" );
		public static readonly IfcWindowTypeEnum LIGHTDOME = new IfcWindowTypeEnum( "LIGHTDOME" );
		public static readonly IfcWindowTypeEnum USERDEFINED = new IfcWindowTypeEnum( "USERDEFINED" );
		public static readonly IfcWindowTypeEnum NOTDEFINED = new IfcWindowTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWindowTypePartitioningEnum : BaseType
	{
	private readonly string ename;
		private IfcWindowTypePartitioningEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWindowTypePartitioningEnum SINGLE_PANEL = new IfcWindowTypePartitioningEnum( "SINGLE_PANEL" );
		public static readonly IfcWindowTypePartitioningEnum DOUBLE_PANEL_VERTICAL = new IfcWindowTypePartitioningEnum( "DOUBLE_PANEL_VERTICAL" );
		public static readonly IfcWindowTypePartitioningEnum DOUBLE_PANEL_HORIZONTAL = new IfcWindowTypePartitioningEnum( "DOUBLE_PANEL_HORIZONTAL" );
		public static readonly IfcWindowTypePartitioningEnum TRIPLE_PANEL_VERTICAL = new IfcWindowTypePartitioningEnum( "TRIPLE_PANEL_VERTICAL" );
		public static readonly IfcWindowTypePartitioningEnum TRIPLE_PANEL_BOTTOM = new IfcWindowTypePartitioningEnum( "TRIPLE_PANEL_BOTTOM" );
		public static readonly IfcWindowTypePartitioningEnum TRIPLE_PANEL_TOP = new IfcWindowTypePartitioningEnum( "TRIPLE_PANEL_TOP" );
		public static readonly IfcWindowTypePartitioningEnum TRIPLE_PANEL_LEFT = new IfcWindowTypePartitioningEnum( "TRIPLE_PANEL_LEFT" );
		public static readonly IfcWindowTypePartitioningEnum TRIPLE_PANEL_RIGHT = new IfcWindowTypePartitioningEnum( "TRIPLE_PANEL_RIGHT" );
		public static readonly IfcWindowTypePartitioningEnum TRIPLE_PANEL_HORIZONTAL = new IfcWindowTypePartitioningEnum( "TRIPLE_PANEL_HORIZONTAL" );
		public static readonly IfcWindowTypePartitioningEnum USERDEFINED = new IfcWindowTypePartitioningEnum( "USERDEFINED" );
		public static readonly IfcWindowTypePartitioningEnum NOTDEFINED = new IfcWindowTypePartitioningEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWorkCalendarTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWorkCalendarTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWorkCalendarTypeEnum FIRSTSHIFT = new IfcWorkCalendarTypeEnum( "FIRSTSHIFT" );
		public static readonly IfcWorkCalendarTypeEnum SECONDSHIFT = new IfcWorkCalendarTypeEnum( "SECONDSHIFT" );
		public static readonly IfcWorkCalendarTypeEnum THIRDSHIFT = new IfcWorkCalendarTypeEnum( "THIRDSHIFT" );
		public static readonly IfcWorkCalendarTypeEnum USERDEFINED = new IfcWorkCalendarTypeEnum( "USERDEFINED" );
		public static readonly IfcWorkCalendarTypeEnum NOTDEFINED = new IfcWorkCalendarTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWorkPlanTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWorkPlanTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWorkPlanTypeEnum ACTUAL = new IfcWorkPlanTypeEnum( "ACTUAL" );
		public static readonly IfcWorkPlanTypeEnum BASELINE = new IfcWorkPlanTypeEnum( "BASELINE" );
		public static readonly IfcWorkPlanTypeEnum PLANNED = new IfcWorkPlanTypeEnum( "PLANNED" );
		public static readonly IfcWorkPlanTypeEnum USERDEFINED = new IfcWorkPlanTypeEnum( "USERDEFINED" );
		public static readonly IfcWorkPlanTypeEnum NOTDEFINED = new IfcWorkPlanTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	public class IfcWorkScheduleTypeEnum : BaseType
	{
	private readonly string ename;
		private IfcWorkScheduleTypeEnum (string enumName)
		{ ename = enumName; }
		public static readonly IfcWorkScheduleTypeEnum ACTUAL = new IfcWorkScheduleTypeEnum( "ACTUAL" );
		public static readonly IfcWorkScheduleTypeEnum BASELINE = new IfcWorkScheduleTypeEnum( "BASELINE" );
		public static readonly IfcWorkScheduleTypeEnum PLANNED = new IfcWorkScheduleTypeEnum( "PLANNED" );
		public static readonly IfcWorkScheduleTypeEnum USERDEFINED = new IfcWorkScheduleTypeEnum( "USERDEFINED" );
		public static readonly IfcWorkScheduleTypeEnum NOTDEFINED = new IfcWorkScheduleTypeEnum( "NOTDEFINED" );
		public override void WriteToP21(StreamWriter writer)
		{
			writer.Write("." + ename + ".");
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcActorSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcOrganization AIfcOrganization;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPerson AIfcPerson;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPersonAndOrganization AIfcPersonAndOrganization;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcAppliedValueSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMeasureWithUnit AIfcMeasureWithUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcReference AIfcReference;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcValue AIfcValue;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcAxis2Placement
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAxis2Placement2D AIfcAxis2Placement2D;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAxis2Placement3D AIfcAxis2Placement3D;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcBendingParameterSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLengthMeasure AIfcLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPlaneAngleMeasure AIfcPlaneAngleMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcBooleanOperand
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBooleanResult AIfcBooleanResult;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCsgPrimitive3D AIfcCsgPrimitive3D;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcHalfSpaceSolid AIfcHalfSpaceSolid;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSolidModel AIfcSolidModel;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcClassificationReferenceSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClassification AIfcClassification;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClassificationReference AIfcClassificationReference;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcClassificationSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClassification AIfcClassification;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClassificationReference AIfcClassificationReference;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcColour
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcColourSpecification AIfcColourSpecification;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPreDefinedColour AIfcPreDefinedColour;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcColourOrFactor
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcColourRgb AIfcColourRgb;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNormalisedRatioMeasure AIfcNormalisedRatioMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCoordinateReferenceSystemSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCoordinateReferenceSystem AIfcCoordinateReferenceSystem;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcGeometricRepresentationContext AIfcGeometricRepresentationContext;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCsgSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBooleanResult AIfcBooleanResult;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCsgPrimitive3D AIfcCsgPrimitive3D;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCurveFontOrScaledCurveFontSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurveStyleFontAndScaling AIfcCurveStyleFontAndScaling;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurveStyleFontSelect AIfcCurveStyleFontSelect;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCurveOnSurface
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCompositeCurveOnSurface AIfcCompositeCurveOnSurface;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPcurve AIfcPcurve;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCurveOrEdgeCurve
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoundedCurve AIfcBoundedCurve;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcEdgeCurve AIfcEdgeCurve;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcCurveStyleFontSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurveStyleFont AIfcCurveStyleFont;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPreDefinedCurveFont AIfcPreDefinedCurveFont;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcDefinitionSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcObjectDefinition AIfcObjectDefinition;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPropertyDefinition AIfcPropertyDefinition;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcDerivedMeasureValue
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAbsorbedDoseMeasure AIfcAbsorbedDoseMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAccelerationMeasure AIfcAccelerationMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAngularVelocityMeasure AIfcAngularVelocityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAreaDensityMeasure AIfcAreaDensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCompoundPlaneAngleMeasure AIfcCompoundPlaneAngleMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurvatureMeasure AIfcCurvatureMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDoseEquivalentMeasure AIfcDoseEquivalentMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDynamicViscosityMeasure AIfcDynamicViscosityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricCapacitanceMeasure AIfcElectricCapacitanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricChargeMeasure AIfcElectricChargeMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricConductanceMeasure AIfcElectricConductanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricResistanceMeasure AIfcElectricResistanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricVoltageMeasure AIfcElectricVoltageMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcEnergyMeasure AIfcEnergyMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcForceMeasure AIfcForceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFrequencyMeasure AIfcFrequencyMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcHeatFluxDensityMeasure AIfcHeatFluxDensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcHeatingValueMeasure AIfcHeatingValueMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIlluminanceMeasure AIfcIlluminanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcInductanceMeasure AIfcInductanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIntegerCountRateMeasure AIfcIntegerCountRateMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIonConcentrationMeasure AIfcIonConcentrationMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIsothermalMoistureCapacityMeasure AIfcIsothermalMoistureCapacityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcKinematicViscosityMeasure AIfcKinematicViscosityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearForceMeasure AIfcLinearForceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearMomentMeasure AIfcLinearMomentMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearStiffnessMeasure AIfcLinearStiffnessMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearVelocityMeasure AIfcLinearVelocityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLuminousFluxMeasure AIfcLuminousFluxMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLuminousIntensityDistributionMeasure AIfcLuminousIntensityDistributionMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMagneticFluxDensityMeasure AIfcMagneticFluxDensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMagneticFluxMeasure AIfcMagneticFluxMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMassDensityMeasure AIfcMassDensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMassFlowRateMeasure AIfcMassFlowRateMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMassPerLengthMeasure AIfcMassPerLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfElasticityMeasure AIfcModulusOfElasticityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfLinearSubgradeReactionMeasure AIfcModulusOfLinearSubgradeReactionMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfRotationalSubgradeReactionMeasure AIfcModulusOfRotationalSubgradeReactionMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfSubgradeReactionMeasure AIfcModulusOfSubgradeReactionMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMoistureDiffusivityMeasure AIfcMoistureDiffusivityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMolecularWeightMeasure AIfcMolecularWeightMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMomentOfInertiaMeasure AIfcMomentOfInertiaMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMonetaryMeasure AIfcMonetaryMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPHMeasure AIfcPHMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPlanarForceMeasure AIfcPlanarForceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPowerMeasure AIfcPowerMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPressureMeasure AIfcPressureMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRadioActivityMeasure AIfcRadioActivityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRotationalFrequencyMeasure AIfcRotationalFrequencyMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRotationalMassMeasure AIfcRotationalMassMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRotationalStiffnessMeasure AIfcRotationalStiffnessMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSectionalAreaIntegralMeasure AIfcSectionalAreaIntegralMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSectionModulusMeasure AIfcSectionModulusMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcShearModulusMeasure AIfcShearModulusMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSoundPowerLevelMeasure AIfcSoundPowerLevelMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSoundPowerMeasure AIfcSoundPowerMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSoundPressureLevelMeasure AIfcSoundPressureLevelMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSoundPressureMeasure AIfcSoundPressureMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSpecificHeatCapacityMeasure AIfcSpecificHeatCapacityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTemperatureGradientMeasure AIfcTemperatureGradientMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTemperatureRateOfChangeMeasure AIfcTemperatureRateOfChangeMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalAdmittanceMeasure AIfcThermalAdmittanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalConductivityMeasure AIfcThermalConductivityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalExpansionCoefficientMeasure AIfcThermalExpansionCoefficientMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalResistanceMeasure AIfcThermalResistanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermalTransmittanceMeasure AIfcThermalTransmittanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTorqueMeasure AIfcTorqueMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVaporPermeabilityMeasure AIfcVaporPermeabilityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVolumetricFlowRateMeasure AIfcVolumetricFlowRateMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcWarpingConstantMeasure AIfcWarpingConstantMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcWarpingMomentMeasure AIfcWarpingMomentMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcDocumentSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDocumentInformation AIfcDocumentInformation;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDocumentReference AIfcDocumentReference;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcFillStyleSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcColour AIfcColour;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternallyDefinedHatchStyle AIfcExternallyDefinedHatchStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFillAreaStyleHatching AIfcFillAreaStyleHatching;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFillAreaStyleTiles AIfcFillAreaStyleTiles;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcGeometricSetSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurve AIfcCurve;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPoint AIfcPoint;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurface AIfcSurface;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcGridPlacementDirectionSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDirection AIfcDirection;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVirtualGridIntersection AIfcVirtualGridIntersection;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcHatchLineDistanceSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveLengthMeasure AIfcPositiveLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVector AIfcVector;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcLayeredItem
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRepresentation AIfcRepresentation;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRepresentationItem AIfcRepresentationItem;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcLibrarySelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLibraryInformation AIfcLibraryInformation;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLibraryReference AIfcLibraryReference;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcLightDistributionDataSourceSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternalReference AIfcExternalReference;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLightIntensityDistribution AIfcLightIntensityDistribution;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcMaterialSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialDefinition AIfcMaterialDefinition;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialList AIfcMaterialList;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialUsageDefinition AIfcMaterialUsageDefinition;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcMeasureValue
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAmountOfSubstanceMeasure AIfcAmountOfSubstanceMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAreaMeasure AIfcAreaMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcComplexNumber AIfcComplexNumber;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcContextDependentMeasure AIfcContextDependentMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCountMeasure AIfcCountMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDescriptiveMeasure AIfcDescriptiveMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElectricCurrentMeasure AIfcElectricCurrentMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLengthMeasure AIfcLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLuminousIntensityMeasure AIfcLuminousIntensityMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMassMeasure AIfcMassMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNonNegativeLengthMeasure AIfcNonNegativeLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNormalisedRatioMeasure AIfcNormalisedRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNumericMeasure AIfcNumericMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcParameterValue AIfcParameterValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPlaneAngleMeasure AIfcPlaneAngleMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveLengthMeasure AIfcPositiveLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositivePlaneAngleMeasure AIfcPositivePlaneAngleMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveRatioMeasure AIfcPositiveRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRatioMeasure AIfcRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSolidAngleMeasure AIfcSolidAngleMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcThermodynamicTemperatureMeasure AIfcThermodynamicTemperatureMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeMeasure AIfcTimeMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVolumeMeasure AIfcVolumeMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcMetricValueSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAppliedValue AIfcAppliedValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMeasureWithUnit AIfcMeasureWithUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcReference AIfcReference;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTable AIfcTable;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeSeries AIfcTimeSeries;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcValue AIfcValue;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcModulusOfRotationalSubgradeReactionSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoolean AIfcBoolean;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfRotationalSubgradeReactionMeasure AIfcModulusOfRotationalSubgradeReactionMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcModulusOfSubgradeReactionSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoolean AIfcBoolean;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfSubgradeReactionMeasure AIfcModulusOfSubgradeReactionMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcModulusOfTranslationalSubgradeReactionSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoolean AIfcBoolean;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcModulusOfLinearSubgradeReactionMeasure AIfcModulusOfLinearSubgradeReactionMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcObjectReferenceSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAddress AIfcAddress;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAppliedValue AIfcAppliedValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternalReference AIfcExternalReference;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialDefinition AIfcMaterialDefinition;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcOrganization AIfcOrganization;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPerson AIfcPerson;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPersonAndOrganization AIfcPersonAndOrganization;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTable AIfcTable;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeSeries AIfcTimeSeries;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcPointOrVertexPoint
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPoint AIfcPoint;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVertexPoint AIfcVertexPoint;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcPresentationStyleSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCurveStyle AIfcCurveStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFillAreaStyle AIfcFillAreaStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNullStyle AIfcNullStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyle AIfcSurfaceStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTextStyle AIfcTextStyle;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcProcessSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcProcess AIfcProcess;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTypeProcess AIfcTypeProcess;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcProductRepresentationSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcProductDefinitionShape AIfcProductDefinitionShape;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRepresentationMap AIfcRepresentationMap;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcProductSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcProduct AIfcProduct;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTypeProduct AIfcTypeProduct;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcPropertySetDefinitionSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPropertySetDefinition AIfcPropertySetDefinition;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPropertySetDefinitionSet AIfcPropertySetDefinitionSet;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcResourceObjectSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcActorRole AIfcActorRole;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcAppliedValue AIfcAppliedValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcApproval AIfcApproval;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcConstraint AIfcConstraint;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcContextDependentUnit AIfcContextDependentUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcConversionBasedUnit AIfcConversionBasedUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternalInformation AIfcExternalInformation;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternalReference AIfcExternalReference;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMaterialDefinition AIfcMaterialDefinition;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcOrganization AIfcOrganization;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPerson AIfcPerson;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPersonAndOrganization AIfcPersonAndOrganization;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPhysicalQuantity AIfcPhysicalQuantity;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcProfileDef AIfcProfileDef;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPropertyAbstraction AIfcPropertyAbstraction;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeSeries AIfcTimeSeries;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcResourceSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcResource AIfcResource;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTypeResource AIfcTypeResource;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcRotationalStiffnessSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoolean AIfcBoolean;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRotationalStiffnessMeasure AIfcRotationalStiffnessMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcShell
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClosedShell AIfcClosedShell;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcOpenShell AIfcOpenShell;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSimpleValue
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoolean AIfcBoolean;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDate AIfcDate;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDateTime AIfcDateTime;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDuration AIfcDuration;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcIdentifier AIfcIdentifier;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcInteger AIfcInteger;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLabel AIfcLabel;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLogical AIfcLogical;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcReal AIfcReal;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcText AIfcText;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTime AIfcTime;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcTimeStamp AIfcTimeStamp;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSizeSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDescriptiveMeasure AIfcDescriptiveMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLengthMeasure AIfcLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNormalisedRatioMeasure AIfcNormalisedRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveLengthMeasure AIfcPositiveLengthMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPositiveRatioMeasure AIfcPositiveRatioMeasure;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRatioMeasure AIfcRatioMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSolidOrShell
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcClosedShell AIfcClosedShell;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSolidModel AIfcSolidModel;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSpaceBoundarySelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternalSpatialElement AIfcExternalSpatialElement;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSpace AIfcSpace;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSpecularHighlightSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSpecularExponent AIfcSpecularExponent;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSpecularRoughness AIfcSpecularRoughness;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcStructuralActivityAssignmentSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcElement AIfcElement;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcStructuralItem AIfcStructuralItem;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcStyleAssignmentSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPresentationStyle AIfcPresentationStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPresentationStyleAssignment AIfcPresentationStyleAssignment;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSurfaceOrFaceSurface
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFaceBasedSurfaceModel AIfcFaceBasedSurfaceModel;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcFaceSurface AIfcFaceSurface;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurface AIfcSurface;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcSurfaceStyleElementSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternallyDefinedSurfaceStyle AIfcExternallyDefinedSurfaceStyle;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyleLighting AIfcSurfaceStyleLighting;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyleRefraction AIfcSurfaceStyleRefraction;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyleShading AIfcSurfaceStyleShading;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSurfaceStyleWithTextures AIfcSurfaceStyleWithTextures;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcTextFontSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcExternallyDefinedTextFont AIfcExternallyDefinedTextFont;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcPreDefinedTextFont AIfcPreDefinedTextFont;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcTimeOrRatioSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDuration AIfcDuration;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcRatioMeasure AIfcRatioMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcTranslationalStiffnessSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoolean AIfcBoolean;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcLinearStiffnessMeasure AIfcLinearStiffnessMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcTrimmingSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcCartesianPoint AIfcCartesianPoint;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcParameterValue AIfcParameterValue;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcUnit
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDerivedUnit AIfcDerivedUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMonetaryUnit AIfcMonetaryUnit;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcNamedUnit AIfcNamedUnit;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcValue
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDerivedMeasureValue AIfcDerivedMeasureValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcMeasureValue AIfcMeasureValue;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcSimpleValue AIfcSimpleValue;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcVectorOrDirection
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcDirection AIfcDirection;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcVector AIfcVector;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	public struct IfcWarpingStiffnessSelect
	{
		[System.Runtime.InteropServices.FieldOffset(0)]
		public P21Base Value;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcBoolean AIfcBoolean;
		[System.Runtime.InteropServices.FieldOffset(0)]
		public IfcWarpingMomentMeasure AIfcWarpingMomentMeasure;
		public void WriteToP21(StreamWriter writer)
		{
			if(Value != null)
			{
				if (Value is P21Instance)
				{
					var vi = Value as P21Instance;
					writer.Write(EbConstants.Sharp + vi.EIN.ToString());
				}
				else
				{
					writer.Write(Value.GetType().Name.ToUpper() + EbConstants.LParentheses);
					Value.WriteToP21(writer);
					writer.Write(EbConstants.RParentheses);
				}
			}
			else
			{ writer.Write(EbConstants.Dollar); }
		}
	}

	public partial class IfcActionRequest : IfcControl

		public IfcActionRequest(){}

		public IfcActionRequestTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcLabel Status;

		[ImmediateAttribute]
		public IfcText LongDescription;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcControl : IfcObject

		public IfcControl(){}

		public IfcIdentifier Identification;

		[InverseAttribute]
		public List< IfcRelAssignsToControl> Controls;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcActor : IfcObject

		public IfcActor(){}

		public IfcActorSelect TheActor;

		[InverseAttribute]
		public List< IfcRelAssignsToActor> IsActingUpon;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TheActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TheActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TheActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOccupant : IfcActor

		public IfcOccupant(){}

		public IfcOccupantTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TheActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TheActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TheActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcObject : IfcObjectDefinition

		public IfcObject(){}

		public IfcLabel ObjectType;

		[InverseAttribute]
		public List< IfcRelDefinesByObject> IsDeclaredBy;

		[InverseAttribute]
		public List< IfcRelDefinesByObject> Declares;

		[InverseAttribute]
		public List< IfcRelDefinesByType> IsTypedBy;

		[InverseAttribute]
		public List< IfcRelDefinesByProperties> IsDefinedBy;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcActorRole : P21Instance

		public IfcActorRole(){}

		public IfcRoleEnum Role;

		[ImmediateAttribute]
		public IfcLabel UserDefinedRole;

		[ImmediateAttribute]
		public IfcText Description;

		[InverseAttribute]
		public List< IfcExternalReferenceRelationship> HasExternalReference;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Role == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Role.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Role.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedRole == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedRole.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedRole.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcActuator : IfcDistributionControlElement

		public IfcActuator(){}

		public IfcActuatorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionControlElement : IfcDistributionElement

		public IfcDistributionControlElement(){}

		public List< IfcRelFlowControlElements> AssignedToFlowElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcActuatorType : IfcDistributionControlElementType

		public IfcActuatorType(){}

		public IfcActuatorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionControlElementType : IfcDistributionElementType

		public IfcDistributionControlElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAddress : P21Instance

		public IfcAddress(){}

		public IfcAddressTypeEnum Purpose;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcLabel UserDefinedPurpose;

		[InverseAttribute]
		public List< IfcPerson> OfPerson;

		[InverseAttribute]
		public List< IfcOrganization> OfOrganization;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPurpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPurpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPurpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPostalAddress : IfcAddress

		public IfcPostalAddress(){}

		public IfcLabel InternalLocation;

		[ImmediateAttribute]
		public List< IfcLabel> AddressLines;

		[ImmediateAttribute]
		public IfcLabel PostalBox;

		[ImmediateAttribute]
		public IfcLabel Town;

		[ImmediateAttribute]
		public IfcLabel Region;

		[ImmediateAttribute]
		public IfcLabel PostalCode;

		[ImmediateAttribute]
		public IfcLabel Country;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPurpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPurpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPurpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InternalLocation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InternalLocation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InternalLocation.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			AddressLines.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (PostalBox == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PostalBox.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PostalBox.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Town == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Town.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Town.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Region == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Region.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Region.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PostalCode == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PostalCode.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PostalCode.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Country == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Country.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Country.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTelecomAddress : IfcAddress

		public IfcTelecomAddress(){}

		public List< IfcLabel> TelephoneNumbers;

		[ImmediateAttribute]
		public List< IfcLabel> FacsimileNumbers;

		[ImmediateAttribute]
		public IfcLabel PagerNumber;

		[ImmediateAttribute]
		public List< IfcLabel> ElectronicMailAddresses;

		[ImmediateAttribute]
		public IfcURIReference WWWHomePageURL;

		[ImmediateAttribute]
		public List< IfcURIReference> MessagingIDs;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPurpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPurpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPurpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			TelephoneNumbers.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			FacsimileNumbers.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (PagerNumber == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PagerNumber.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PagerNumber.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ElectronicMailAddresses.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (WWWHomePageURL == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WWWHomePageURL.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WWWHomePageURL.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			MessagingIDs.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAdvancedBrep : IfcManifoldSolidBrep

		public IfcAdvancedBrep(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Outer == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Outer.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Outer.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAdvancedBrepWithVoids : IfcAdvancedBrep

		public IfcAdvancedBrepWithVoids(){}

		public List< IfcClosedShell> Voids;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Outer == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Outer.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Outer.EIN); }
			p21File.Write(EbConstants.Comma);
			Voids.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcManifoldSolidBrep : IfcSolidModel

		public IfcManifoldSolidBrep(){}

		public IfcClosedShell Outer;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Outer == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Outer.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Outer.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAdvancedFace : IfcFaceSurface

		public IfcAdvancedFace(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Bounds.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (FaceSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FaceSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + FaceSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFaceSurface : IfcFace

		public IfcFaceSurface(){}

		public IfcSurface FaceSurface;

		[ImmediateAttribute]
		public BOOLEAN SameSense;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Bounds.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (FaceSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FaceSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + FaceSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirTerminal : IfcFlowTerminal

		public IfcAirTerminal(){}

		public IfcAirTerminalTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowTerminal : IfcDistributionFlowElement

		public IfcFlowTerminal(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirTerminalBox : IfcFlowController

		public IfcAirTerminalBox(){}

		public IfcAirTerminalBoxTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowController : IfcDistributionFlowElement

		public IfcFlowController(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirTerminalBoxType : IfcFlowControllerType

		public IfcAirTerminalBoxType(){}

		public IfcAirTerminalBoxTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowControllerType : IfcDistributionFlowElementType

		public IfcFlowControllerType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirTerminalType : IfcFlowTerminalType

		public IfcAirTerminalType(){}

		public IfcAirTerminalTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowTerminalType : IfcDistributionFlowElementType

		public IfcFlowTerminalType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirToAirHeatRecovery : IfcEnergyConversionDevice

		public IfcAirToAirHeatRecovery(){}

		public IfcAirToAirHeatRecoveryTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEnergyConversionDevice : IfcDistributionFlowElement

		public IfcEnergyConversionDevice(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAirToAirHeatRecoveryType : IfcEnergyConversionDeviceType

		public IfcAirToAirHeatRecoveryType(){}

		public IfcAirToAirHeatRecoveryTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEnergyConversionDeviceType : IfcDistributionFlowElementType

		public IfcEnergyConversionDeviceType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAlarm : IfcDistributionControlElement

		public IfcAlarm(){}

		public IfcAlarmTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAlarmType : IfcDistributionControlElementType

		public IfcAlarmType(){}

		public IfcAlarmTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotation : IfcProduct

		public IfcAnnotation(){}

		public List< IfcRelContainedInSpatialStructure> ContainedInStructure;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProduct : IfcObject

		public IfcProduct(){}

		public IfcObjectPlacement ObjectPlacement;

		[ImmediateAttribute]
		public IfcProductRepresentation Representation;

		[InverseAttribute]
		public List< IfcRelAssignsToProduct> ReferencedBy;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAnnotationFillArea : IfcGeometricRepresentationItem

		public IfcAnnotationFillArea(){}

		public IfcCurve OuterBoundary;

		[ImmediateAttribute]
		public List< IfcCurve> InnerBoundaries;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (OuterBoundary == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OuterBoundary.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OuterBoundary.EIN); }
			p21File.Write(EbConstants.Comma);
			InnerBoundaries.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeometricRepresentationItem : IfcRepresentationItem

		public IfcGeometricRepresentationItem(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcApplication : P21Instance

		public IfcApplication(){}

		public IfcOrganization ApplicationDeveloper;

		[ImmediateAttribute]
		public IfcLabel Version;

		[ImmediateAttribute]
		public IfcLabel ApplicationFullName;

		[ImmediateAttribute]
		public IfcIdentifier ApplicationIdentifier;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ApplicationDeveloper == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicationDeveloper.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ApplicationDeveloper.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Version == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Version.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Version.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicationFullName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicationFullName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicationFullName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicationIdentifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicationIdentifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicationIdentifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAppliedValue : P21Instance

		public IfcAppliedValue(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcAppliedValueSelect AppliedValue;

		[ImmediateAttribute]
		public IfcMeasureWithUnit UnitBasis;

		[ImmediateAttribute]
		public IfcDate ApplicableDate;

		[ImmediateAttribute]
		public IfcDate FixedUntilDate;

		[ImmediateAttribute]
		public IfcLabel Category;

		[ImmediateAttribute]
		public IfcLabel Condition;

		[ImmediateAttribute]
		public IfcArithmeticOperatorEnum ArithmeticOperator;

		[ImmediateAttribute]
		public List< IfcAppliedValue> Components;

		[InverseAttribute]
		public List< IfcExternalReferenceRelationship> HasExternalReference;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AppliedValue.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AppliedValue.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AppliedValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UnitBasis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitBasis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + UnitBasis.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FixedUntilDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FixedUntilDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FixedUntilDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Category == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Category.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Category.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Condition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Condition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Condition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ArithmeticOperator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ArithmeticOperator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ArithmeticOperator.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Components.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCostValue : IfcAppliedValue

		public IfcCostValue(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AppliedValue.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AppliedValue.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AppliedValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UnitBasis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitBasis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + UnitBasis.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FixedUntilDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FixedUntilDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FixedUntilDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Category == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Category.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Category.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Condition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Condition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Condition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ArithmeticOperator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ArithmeticOperator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ArithmeticOperator.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Components.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcApproval : P21Instance

		public IfcApproval(){}

		public IfcIdentifier Identifier;

		[ImmediateAttribute]
		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcDateTime TimeOfApproval;

		[ImmediateAttribute]
		public IfcLabel Status;

		[ImmediateAttribute]
		public IfcLabel Level;

		[ImmediateAttribute]
		public IfcText Qualifier;

		[ImmediateAttribute]
		public IfcActorSelect RequestingApproval;

		[ImmediateAttribute]
		public IfcActorSelect GivingApproval;

		[InverseAttribute]
		public List< IfcExternalReferenceRelationship> HasExternalReferences;

		[InverseAttribute]
		public List< IfcRelAssociatesApproval> ApprovedObjects;

		[InverseAttribute]
		public List< IfcResourceApprovalRelationship> ApprovedResources;

		[InverseAttribute]
		public List< IfcApprovalRelationship> IsRelatedWith;

		[InverseAttribute]
		public List< IfcApprovalRelationship> Relates;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Identifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TimeOfApproval == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeOfApproval.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TimeOfApproval.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Level == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Level.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Level.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Qualifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Qualifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Qualifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RequestingApproval.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RequestingApproval.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RequestingApproval.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (GivingApproval.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GivingApproval.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GivingApproval.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcApprovalRelationship : IfcResourceLevelRelationship

		public IfcApprovalRelationship(){}

		public IfcApproval RelatingApproval;

		[ImmediateAttribute]
		public List< IfcApproval> RelatedApprovals;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RelatingApproval == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingApproval.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingApproval.EIN); }
			p21File.Write(EbConstants.Comma);
			RelatedApprovals.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcResourceLevelRelationship : P21Instance

		public IfcResourceLevelRelationship(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcArbitraryClosedProfileDef : IfcProfileDef

		public IfcArbitraryClosedProfileDef(){}

		public IfcCurve OuterCurve;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OuterCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OuterCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OuterCurve.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcArbitraryProfileDefWithVoids : IfcArbitraryClosedProfileDef

		public IfcArbitraryProfileDefWithVoids(){}

		public List< IfcCurve> InnerCurves;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OuterCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OuterCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OuterCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			InnerCurves.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProfileDef : P21Instance

		public IfcProfileDef(){}

		public IfcProfileTypeEnum ProfileType;

		[ImmediateAttribute]
		public IfcLabel ProfileName;

		[InverseAttribute]
		public List< IfcExternalReferenceRelationship> HasExternalReference;

		[InverseAttribute]
		public List< IfcProfileProperties> HasProperties;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcArbitraryOpenProfileDef : IfcProfileDef

		public IfcArbitraryOpenProfileDef(){}

		public IfcBoundedCurve Curve;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Curve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Curve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Curve.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef

		public IfcCenterLineProfileDef(){}

		public IfcPositiveLengthMeasure Thickness;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Curve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Curve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Curve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Thickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Thickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Thickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAsset : IfcGroup

		public IfcAsset(){}

		public IfcIdentifier Identification;

		[ImmediateAttribute]
		public IfcCostValue OriginalValue;

		[ImmediateAttribute]
		public IfcCostValue CurrentValue;

		[ImmediateAttribute]
		public IfcCostValue TotalReplacementCost;

		[ImmediateAttribute]
		public IfcActorSelect Owner;

		[ImmediateAttribute]
		public IfcActorSelect User;

		[ImmediateAttribute]
		public IfcPerson ResponsiblePerson;

		[ImmediateAttribute]
		public IfcDate IncorporationDate;

		[ImmediateAttribute]
		public IfcCostValue DepreciatedValue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OriginalValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OriginalValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OriginalValue.EIN); }
			p21File.Write(EbConstants.Comma);
			if (CurrentValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurrentValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + CurrentValue.EIN); }
			p21File.Write(EbConstants.Comma);
			if (TotalReplacementCost == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TotalReplacementCost.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TotalReplacementCost.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Owner.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Owner.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Owner.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (User.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (User.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ User.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResponsiblePerson == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResponsiblePerson.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ResponsiblePerson.EIN); }
			p21File.Write(EbConstants.Comma);
			if (IncorporationDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (IncorporationDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ IncorporationDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DepreciatedValue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DepreciatedValue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + DepreciatedValue.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGroup : IfcObject

		public IfcGroup(){}

		public List< IfcRelAssignsToGroup> IsGroupedBy;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAsymmetricIShapeProfileDef : IfcParameterizedProfileDef

		public IfcAsymmetricIShapeProfileDef(){}

		public IfcPositiveLengthMeasure BottomFlangeWidth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure OverallDepth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure WebThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BottomFlangeThickness;

		[ImmediateAttribute]
		public IfcNonNegativeLengthMeasure BottomFlangeFilletRadius;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure TopFlangeWidth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure TopFlangeThickness;

		[ImmediateAttribute]
		public IfcNonNegativeLengthMeasure TopFlangeFilletRadius;

		[ImmediateAttribute]
		public IfcNonNegativeLengthMeasure BottomFlangeEdgeRadius;

		[ImmediateAttribute]
		public IfcPlaneAngleMeasure BottomFlangeSlope;

		[ImmediateAttribute]
		public IfcNonNegativeLengthMeasure TopFlangeEdgeRadius;

		[ImmediateAttribute]
		public IfcPlaneAngleMeasure TopFlangeSlope;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (BottomFlangeWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BottomFlangeWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BottomFlangeWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WebThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WebThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WebThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BottomFlangeThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BottomFlangeThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BottomFlangeThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BottomFlangeFilletRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BottomFlangeFilletRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BottomFlangeFilletRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TopFlangeWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TopFlangeWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TopFlangeWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TopFlangeThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TopFlangeThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TopFlangeThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TopFlangeFilletRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TopFlangeFilletRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TopFlangeFilletRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BottomFlangeEdgeRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BottomFlangeEdgeRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BottomFlangeEdgeRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BottomFlangeSlope == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BottomFlangeSlope.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BottomFlangeSlope.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TopFlangeEdgeRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TopFlangeEdgeRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TopFlangeEdgeRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TopFlangeSlope == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TopFlangeSlope.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TopFlangeSlope.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcParameterizedProfileDef : IfcProfileDef

		public IfcParameterizedProfileDef(){}

		public IfcAxis2Placement2D Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAudioVisualAppliance : IfcFlowTerminal

		public IfcAudioVisualAppliance(){}

		public IfcAudioVisualApplianceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAudioVisualApplianceType : IfcFlowTerminalType

		public IfcAudioVisualApplianceType(){}

		public IfcAudioVisualApplianceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAxis1Placement : IfcPlacement

		public IfcAxis1Placement(){}

		public IfcDirection Axis;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Location.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPlacement : IfcGeometricRepresentationItem

		public IfcPlacement(){}

		public IfcCartesianPoint Location;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Location.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAxis2Placement2D : IfcPlacement

		public IfcAxis2Placement2D(){}

		public IfcDirection RefDirection;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Location.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RefDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RefDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RefDirection.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcAxis2Placement3D : IfcPlacement

		public IfcAxis2Placement3D(){}

		public IfcDirection Axis;

		[ImmediateAttribute]
		public IfcDirection RefDirection;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Location.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RefDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RefDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RefDirection.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBSplineCurve : IfcBoundedCurve

		public IfcBSplineCurve(){}

		public INTEGER Degree;

		[ImmediateAttribute]
		public List< IfcCartesianPoint> ControlPointsList;

		[ImmediateAttribute]
		public IfcBSplineCurveForm CurveForm;

		[ImmediateAttribute]
		public LOGICAL ClosedCurve;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Degree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Degree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Degree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (CurveForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ClosedCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ClosedCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ClosedCurve.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBSplineCurveWithKnots : IfcBSplineCurve

		public IfcBSplineCurveWithKnots(){}

		public List< INTEGER> KnotMultiplicities;

		[ImmediateAttribute]
		public List< IfcParameterValue> Knots;

		[ImmediateAttribute]
		public IfcKnotType KnotSpec;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Degree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Degree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Degree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (CurveForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ClosedCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ClosedCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ClosedCurve.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			KnotMultiplicities.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			Knots.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (KnotSpec == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (KnotSpec.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ KnotSpec.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundedCurve : IfcCurve

		public IfcBoundedCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRationalBSplineCurveWithKnots : IfcBSplineCurveWithKnots

		public IfcRationalBSplineCurveWithKnots(){}

		public List< REAL> WeightsData;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Degree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Degree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Degree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (CurveForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ClosedCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ClosedCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ClosedCurve.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			KnotMultiplicities.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			Knots.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (KnotSpec == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (KnotSpec.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ KnotSpec.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			WeightsData.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBSplineSurface : IfcBoundedSurface

		public IfcBSplineSurface(){}

		public INTEGER UDegree;

		[ImmediateAttribute]
		public INTEGER VDegree;

		[ImmediateAttribute]
		public List< List< IfcCartesianPoint>> ControlPointsList;

		[ImmediateAttribute]
		public IfcBSplineSurfaceForm SurfaceForm;

		[ImmediateAttribute]
		public LOGICAL UClosed;

		[ImmediateAttribute]
		public LOGICAL VClosed;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (UDegree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UDegree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UDegree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VDegree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VDegree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VDegree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SurfaceForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SurfaceForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SurfaceForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UClosed == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UClosed.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UClosed.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VClosed == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VClosed.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VClosed.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBSplineSurfaceWithKnots : IfcBSplineSurface

		public IfcBSplineSurfaceWithKnots(){}

		public List< INTEGER> UMultiplicities;

		[ImmediateAttribute]
		public List< INTEGER> VMultiplicities;

		[ImmediateAttribute]
		public List< IfcParameterValue> UKnots;

		[ImmediateAttribute]
		public List< IfcParameterValue> VKnots;

		[ImmediateAttribute]
		public IfcKnotType KnotSpec;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (UDegree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UDegree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UDegree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VDegree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VDegree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VDegree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SurfaceForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SurfaceForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SurfaceForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UClosed == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UClosed.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UClosed.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VClosed == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VClosed.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VClosed.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			UMultiplicities.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			VMultiplicities.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			UKnots.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			VKnots.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (KnotSpec == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (KnotSpec.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ KnotSpec.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundedSurface : IfcSurface

		public IfcBoundedSurface(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRationalBSplineSurfaceWithKnots : IfcBSplineSurfaceWithKnots

		public IfcRationalBSplineSurfaceWithKnots(){}

		public List< List< REAL>> WeightsData;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (UDegree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UDegree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UDegree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VDegree == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VDegree.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VDegree.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ControlPointsList.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SurfaceForm == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SurfaceForm.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SurfaceForm.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UClosed == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UClosed.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UClosed.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VClosed == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VClosed.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VClosed.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			UMultiplicities.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			VMultiplicities.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			UKnots.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			VKnots.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (KnotSpec == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (KnotSpec.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ KnotSpec.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			WeightsData.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBeam : IfcBuildingElement

		public IfcBeam(){}

		public IfcBeamTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBeamStandardCase : IfcBeam

		public IfcBeamStandardCase(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElement : IfcElement

		public IfcBuildingElement(){}

		public List< IfcRelCoversBldgElements> HasCoverings;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBeamType : IfcBuildingElementType

		public IfcBeamType(){}

		public IfcBeamTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementType : IfcElementType

		public IfcBuildingElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBlobTexture : IfcSurfaceTexture

		public IfcBlobTexture(){}

		public IfcIdentifier RasterFormat;

		[ImmediateAttribute]
		public BINARY RasterCode;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RepeatS == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatS.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatS.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RepeatT == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatT.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatT.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Mode == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Mode.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Mode.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TextureTransform == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureTransform.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TextureTransform.EIN); }
			p21File.Write(EbConstants.Comma);
			Parameter.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (RasterFormat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RasterFormat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RasterFormat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RasterCode == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RasterCode.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RasterCode.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSurfaceTexture : IfcPresentationItem

		public IfcSurfaceTexture(){}

		public BOOLEAN RepeatS;

		[ImmediateAttribute]
		public BOOLEAN RepeatT;

		[ImmediateAttribute]
		public IfcIdentifier Mode;

		[ImmediateAttribute]
		public IfcCartesianTransformationOperator2D TextureTransform;

		[ImmediateAttribute]
		public List< IfcIdentifier> Parameter;

		[InverseAttribute]
		public List< IfcTextureCoordinate> IsMappedBy;

		[InverseAttribute]
		public List< IfcSurfaceStyleWithTextures> UsedInStyles;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (RepeatS == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatS.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatS.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RepeatT == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RepeatT.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RepeatT.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Mode == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Mode.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Mode.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TextureTransform == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TextureTransform.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TextureTransform.EIN); }
			p21File.Write(EbConstants.Comma);
			Parameter.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBlock : IfcCsgPrimitive3D

		public IfcBlock(){}

		public IfcPositiveLengthMeasure XLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure YLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure ZLength;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (XLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (XLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ XLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (YLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (YLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ YLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ZLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ZLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ZLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCsgPrimitive3D : IfcGeometricRepresentationItem

		public IfcCsgPrimitive3D(){}

		public IfcAxis2Placement3D Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoiler : IfcEnergyConversionDevice

		public IfcBoiler(){}

		public IfcBoilerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoilerType : IfcEnergyConversionDeviceType

		public IfcBoilerType(){}

		public IfcBoilerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBooleanClippingResult : IfcBooleanResult

		public IfcBooleanClippingResult(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Operator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Operator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Operator.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FirstOperand.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FirstOperand.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FirstOperand.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SecondOperand.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SecondOperand.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SecondOperand.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBooleanResult : IfcGeometricRepresentationItem

		public IfcBooleanResult(){}

		public IfcBooleanOperator Operator;

		[ImmediateAttribute]
		public IfcBooleanOperand FirstOperand;

		[ImmediateAttribute]
		public IfcBooleanOperand SecondOperand;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Operator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Operator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Operator.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FirstOperand.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FirstOperand.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FirstOperand.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SecondOperand.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SecondOperand.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SecondOperand.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryCondition : P21Instance

		public IfcBoundaryCondition(){}

		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryEdgeCondition : IfcBoundaryCondition

		public IfcBoundaryEdgeCondition(){}

		public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthX;

		[ImmediateAttribute]
		public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthY;

		[ImmediateAttribute]
		public IfcModulusOfTranslationalSubgradeReactionSelect TranslationalStiffnessByLengthZ;

		[ImmediateAttribute]
		public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthX;

		[ImmediateAttribute]
		public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthY;

		[ImmediateAttribute]
		public IfcModulusOfRotationalSubgradeReactionSelect RotationalStiffnessByLengthZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessByLengthX.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessByLengthX.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessByLengthX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessByLengthY.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessByLengthY.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessByLengthY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessByLengthZ.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessByLengthZ.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessByLengthZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessByLengthX.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessByLengthX.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessByLengthX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessByLengthY.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessByLengthY.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessByLengthY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessByLengthZ.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessByLengthZ.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessByLengthZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryFaceCondition : IfcBoundaryCondition

		public IfcBoundaryFaceCondition(){}

		public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaX;

		[ImmediateAttribute]
		public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaY;

		[ImmediateAttribute]
		public IfcModulusOfSubgradeReactionSelect TranslationalStiffnessByAreaZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessByAreaX.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessByAreaX.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessByAreaX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessByAreaY.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessByAreaY.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessByAreaY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessByAreaZ.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessByAreaZ.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessByAreaZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryNodeCondition : IfcBoundaryCondition

		public IfcBoundaryNodeCondition(){}

		public IfcTranslationalStiffnessSelect TranslationalStiffnessX;

		[ImmediateAttribute]
		public IfcTranslationalStiffnessSelect TranslationalStiffnessY;

		[ImmediateAttribute]
		public IfcTranslationalStiffnessSelect TranslationalStiffnessZ;

		[ImmediateAttribute]
		public IfcRotationalStiffnessSelect RotationalStiffnessX;

		[ImmediateAttribute]
		public IfcRotationalStiffnessSelect RotationalStiffnessY;

		[ImmediateAttribute]
		public IfcRotationalStiffnessSelect RotationalStiffnessZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessX.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessX.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessY.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessY.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessZ.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessZ.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessX.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessX.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessY.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessY.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessZ.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessZ.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryCurve : IfcCompositeCurveOnSurface

		public IfcBoundaryCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Segments.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOuterBoundaryCurve : IfcBoundaryCurve

		public IfcOuterBoundaryCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Segments.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompositeCurveOnSurface : IfcCompositeCurve

		public IfcCompositeCurveOnSurface(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Segments.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition

		public IfcBoundaryNodeConditionWarping(){}

		public IfcWarpingStiffnessSelect WarpingStiffness;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessX.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessX.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessY.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessY.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TranslationalStiffnessZ.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TranslationalStiffnessZ.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TranslationalStiffnessZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessX.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessX.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessY.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessY.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RotationalStiffnessZ.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RotationalStiffnessZ.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RotationalStiffnessZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WarpingStiffness.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WarpingStiffness.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WarpingStiffness.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompositeCurve : IfcBoundedCurve

		public IfcCompositeCurve(){}

		public List< IfcCompositeCurveSegment> Segments;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Segments.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPolyline : IfcBoundedCurve

		public IfcPolyline(){}

		public List< IfcCartesianPoint> Points;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Points.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTrimmedCurve : IfcBoundedCurve

		public IfcTrimmedCurve(){}

		public IfcCurve BasisCurve;

		[ImmediateAttribute]
		public List< IfcTrimmingSelect> Trim1;

		[ImmediateAttribute]
		public List< IfcTrimmingSelect> Trim2;

		[ImmediateAttribute]
		public BOOLEAN SenseAgreement;

		[ImmediateAttribute]
		public IfcTrimmingPreference MasterRepresentation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			Trim1.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			Trim2.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (SenseAgreement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SenseAgreement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SenseAgreement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MasterRepresentation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MasterRepresentation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MasterRepresentation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurve : IfcGeometricRepresentationItem

		public IfcCurve(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveBoundedPlane : IfcBoundedSurface

		public IfcCurveBoundedPlane(){}

		public IfcPlane BasisSurface;

		[ImmediateAttribute]
		public IfcCurve OuterBoundary;

		[ImmediateAttribute]
		public List< IfcCurve> InnerBoundaries;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (OuterBoundary == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OuterBoundary.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OuterBoundary.EIN); }
			p21File.Write(EbConstants.Comma);
			InnerBoundaries.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveBoundedSurface : IfcBoundedSurface

		public IfcCurveBoundedSurface(){}

		public IfcSurface BasisSurface;

		[ImmediateAttribute]
		public List< IfcBoundaryCurve> Boundaries;

		[ImmediateAttribute]
		public BOOLEAN ImplicitOuter;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			Boundaries.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (ImplicitOuter == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ImplicitOuter.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ImplicitOuter.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRectangularTrimmedSurface : IfcBoundedSurface

		public IfcRectangularTrimmedSurface(){}

		public IfcSurface BasisSurface;

		[ImmediateAttribute]
		public IfcParameterValue U1;

		[ImmediateAttribute]
		public IfcParameterValue V1;

		[ImmediateAttribute]
		public IfcParameterValue U2;

		[ImmediateAttribute]
		public IfcParameterValue V2;

		[ImmediateAttribute]
		public BOOLEAN Usense;

		[ImmediateAttribute]
		public BOOLEAN Vsense;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (U1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (U1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ U1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (V1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (V1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ V1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (U2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (U2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ U2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (V2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (V2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ V2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Usense.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Vsense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Vsense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Vsense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSurface : IfcGeometricRepresentationItem

		public IfcSurface(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoundingBox : IfcGeometricRepresentationItem

		public IfcBoundingBox(){}

		public IfcCartesianPoint Corner;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure XDim;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure YDim;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure ZDim;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Corner == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Corner.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Corner.EIN); }
			p21File.Write(EbConstants.Comma);
			if (XDim == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (XDim.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ XDim.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (YDim == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (YDim.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ YDim.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ZDim == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ZDim.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ZDim.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBoxedHalfSpace : IfcHalfSpaceSolid

		public IfcBoxedHalfSpace(){}

		public IfcBoundingBox Enclosure;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BaseSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AgreementFlag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AgreementFlag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AgreementFlag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Enclosure == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Enclosure.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Enclosure.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcHalfSpaceSolid : IfcGeometricRepresentationItem

		public IfcHalfSpaceSolid(){}

		public IfcSurface BaseSurface;

		[ImmediateAttribute]
		public BOOLEAN AgreementFlag;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BaseSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (AgreementFlag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AgreementFlag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AgreementFlag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuilding : IfcSpatialStructureElement

		public IfcBuilding(){}

		public IfcLengthMeasure ElevationOfRefHeight;

		[ImmediateAttribute]
		public IfcLengthMeasure ElevationOfTerrain;

		[ImmediateAttribute]
		public IfcPostalAddress BuildingAddress;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompositionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompositionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompositionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElevationOfRefHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElevationOfRefHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElevationOfRefHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElevationOfTerrain == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElevationOfTerrain.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElevationOfTerrain.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BuildingAddress == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BuildingAddress.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BuildingAddress.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSpatialStructureElement : IfcSpatialElement

		public IfcSpatialStructureElement(){}

		public IfcElementCompositionEnum CompositionType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompositionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompositionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompositionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementProxy : IfcBuildingElement

		public IfcBuildingElementProxy(){}

		public IfcBuildingElementProxyTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcChimney : IfcBuildingElement

		public IfcChimney(){}

		public IfcChimneyTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColumn : IfcBuildingElement

		public IfcColumn(){}

		public IfcColumnTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCovering : IfcBuildingElement

		public IfcCovering(){}

		public IfcCoveringTypeEnum PredefinedType;

		[InverseAttribute]
		public List< IfcRelCoversSpaces> CoversSpaces;

		[InverseAttribute]
		public List< IfcRelCoversBldgElements> CoversElements;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurtainWall : IfcBuildingElement

		public IfcCurtainWall(){}

		public IfcCurtainWallTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoor : IfcBuildingElement

		public IfcDoor(){}

		public IfcPositiveLengthMeasure OverallHeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure OverallWidth;

		[ImmediateAttribute]
		public IfcDoorTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcDoorTypeOperationEnum OperationType;

		[ImmediateAttribute]
		public IfcLabel UserDefinedOperationType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedOperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedOperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedOperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFooting : IfcBuildingElement

		public IfcFooting(){}

		public IfcFootingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMember : IfcBuildingElement

		public IfcMember(){}

		public IfcMemberTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPile : IfcBuildingElement

		public IfcPile(){}

		public IfcPileTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcPileConstructionEnum ConstructionType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstructionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstructionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstructionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPlate : IfcBuildingElement

		public IfcPlate(){}

		public IfcPlateTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRailing : IfcBuildingElement

		public IfcRailing(){}

		public IfcRailingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRamp : IfcBuildingElement

		public IfcRamp(){}

		public IfcRampTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRampFlight : IfcBuildingElement

		public IfcRampFlight(){}

		public IfcRampFlightTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRoof : IfcBuildingElement

		public IfcRoof(){}

		public IfcRoofTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcShadingDevice : IfcBuildingElement

		public IfcShadingDevice(){}

		public IfcShadingDeviceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSlab : IfcBuildingElement

		public IfcSlab(){}

		public IfcSlabTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStair : IfcBuildingElement

		public IfcStair(){}

		public IfcStairTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStairFlight : IfcBuildingElement

		public IfcStairFlight(){}

		public INTEGER NumberOfRiser;

		[ImmediateAttribute]
		public INTEGER NumberOfTreads;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure RiserHeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure TreadLength;

		[ImmediateAttribute]
		public IfcStairFlightTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (NumberOfRiser == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (NumberOfRiser.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ NumberOfRiser.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (NumberOfTreads == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (NumberOfTreads.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ NumberOfTreads.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RiserHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RiserHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RiserHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TreadLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TreadLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TreadLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWall : IfcBuildingElement

		public IfcWall(){}

		public IfcWallTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWindow : IfcBuildingElement

		public IfcWindow(){}

		public IfcPositiveLengthMeasure OverallHeight;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure OverallWidth;

		[ImmediateAttribute]
		public IfcWindowTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcWindowTypePartitioningEnum PartitioningType;

		[ImmediateAttribute]
		public IfcLabel UserDefinedPartitioningType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PartitioningType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PartitioningType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PartitioningType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPartitioningType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPartitioningType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPartitioningType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElement : IfcProduct

		public IfcElement(){}

		public IfcIdentifier Tag;

		[InverseAttribute]
		public List< IfcRelFillsElement> FillsVoids;

		[InverseAttribute]
		public List< IfcRelConnectsElements> ConnectedTo;

		[InverseAttribute]
		public List< IfcRelInterferesElements> IsInterferedByElements;

		[InverseAttribute]
		public List< IfcRelInterferesElements> InterferesElements;

		[InverseAttribute]
		public List< IfcRelProjectsElement> HasProjections;

		[InverseAttribute]
		public List< IfcRelReferencedInSpatialStructure> ReferencedInStructures;

		[InverseAttribute]
		public List< IfcRelVoidsElement> HasOpenings;

		[InverseAttribute]
		public List< IfcRelConnectsWithRealizingElements> IsConnectionRealization;

		[InverseAttribute]
		public List< IfcRelSpaceBoundary> ProvidesBoundaries;

		[InverseAttribute]
		public List< IfcRelConnectsElements> ConnectedFrom;

		[InverseAttribute]
		public List< IfcRelContainedInSpatialStructure> ContainedInStructure;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementPart : IfcElementComponent

		public IfcBuildingElementPart(){}

		public IfcBuildingElementPartTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementComponent : IfcElement

		public IfcElementComponent(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementPartType : IfcElementComponentType

		public IfcBuildingElementPartType(){}

		public IfcBuildingElementPartTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementComponentType : IfcElementType

		public IfcElementComponentType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingElementProxyType : IfcBuildingElementType

		public IfcBuildingElementProxyType(){}

		public IfcBuildingElementProxyTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcChimneyType : IfcBuildingElementType

		public IfcChimneyType(){}

		public IfcChimneyTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColumnType : IfcBuildingElementType

		public IfcColumnType(){}

		public IfcColumnTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoveringType : IfcBuildingElementType

		public IfcCoveringType(){}

		public IfcCoveringTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurtainWallType : IfcBuildingElementType

		public IfcCurtainWallType(){}

		public IfcCurtainWallTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoorType : IfcBuildingElementType

		public IfcDoorType(){}

		public IfcDoorTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcDoorTypeOperationEnum OperationType;

		[ImmediateAttribute]
		public BOOLEAN ParameterTakesPrecedence;

		[ImmediateAttribute]
		public IfcLabel UserDefinedOperationType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParameterTakesPrecedence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParameterTakesPrecedence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ParameterTakesPrecedence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedOperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedOperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedOperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFootingType : IfcBuildingElementType

		public IfcFootingType(){}

		public IfcFootingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMemberType : IfcBuildingElementType

		public IfcMemberType(){}

		public IfcMemberTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPileType : IfcBuildingElementType

		public IfcPileType(){}

		public IfcPileTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPlateType : IfcBuildingElementType

		public IfcPlateType(){}

		public IfcPlateTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRailingType : IfcBuildingElementType

		public IfcRailingType(){}

		public IfcRailingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRampFlightType : IfcBuildingElementType

		public IfcRampFlightType(){}

		public IfcRampFlightTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRampType : IfcBuildingElementType

		public IfcRampType(){}

		public IfcRampTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRoofType : IfcBuildingElementType

		public IfcRoofType(){}

		public IfcRoofTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcShadingDeviceType : IfcBuildingElementType

		public IfcShadingDeviceType(){}

		public IfcShadingDeviceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSlabType : IfcBuildingElementType

		public IfcSlabType(){}

		public IfcSlabTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStairFlightType : IfcBuildingElementType

		public IfcStairFlightType(){}

		public IfcStairFlightTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcStairType : IfcBuildingElementType

		public IfcStairType(){}

		public IfcStairTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWallType : IfcBuildingElementType

		public IfcWallType(){}

		public IfcWallTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWindowType : IfcBuildingElementType

		public IfcWindowType(){}

		public IfcWindowTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcWindowTypePartitioningEnum PartitioningType;

		[ImmediateAttribute]
		public BOOLEAN ParameterTakesPrecedence;

		[ImmediateAttribute]
		public IfcLabel UserDefinedPartitioningType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PartitioningType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PartitioningType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PartitioningType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParameterTakesPrecedence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParameterTakesPrecedence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ParameterTakesPrecedence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedPartitioningType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedPartitioningType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedPartitioningType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementType : IfcTypeProduct

		public IfcElementType(){}

		public IfcLabel ElementType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingStorey : IfcSpatialStructureElement

		public IfcBuildingStorey(){}

		public IfcLengthMeasure Elevation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CompositionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CompositionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CompositionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Elevation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Elevation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Elevation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBuildingSystem : IfcSystem

		public IfcBuildingSystem(){}

		public IfcBuildingSystemTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSystem : IfcGroup

		public IfcSystem(){}

		public List< IfcRelServicesBuildings> ServicesBuildings;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBurner : IfcEnergyConversionDevice

		public IfcBurner(){}

		public IfcBurnerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcBurnerType : IfcEnergyConversionDeviceType

		public IfcBurnerType(){}

		public IfcBurnerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCShapeProfileDef : IfcParameterizedProfileDef

		public IfcCShapeProfileDef(){}

		public IfcPositiveLengthMeasure Depth;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Width;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure WallThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Girth;

		[ImmediateAttribute]
		public IfcNonNegativeLengthMeasure InternalFilletRadius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Depth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Depth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Depth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Width == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Width.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Width.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WallThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WallThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WallThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Girth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Girth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Girth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InternalFilletRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InternalFilletRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InternalFilletRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableCarrierFitting : IfcFlowFitting

		public IfcCableCarrierFitting(){}

		public IfcCableCarrierFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowFitting : IfcDistributionFlowElement

		public IfcFlowFitting(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableCarrierFittingType : IfcFlowFittingType

		public IfcCableCarrierFittingType(){}

		public IfcCableCarrierFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowFittingType : IfcDistributionFlowElementType

		public IfcFlowFittingType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableCarrierSegment : IfcFlowSegment

		public IfcCableCarrierSegment(){}

		public IfcCableCarrierSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowSegment : IfcDistributionFlowElement

		public IfcFlowSegment(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableCarrierSegmentType : IfcFlowSegmentType

		public IfcCableCarrierSegmentType(){}

		public IfcCableCarrierSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowSegmentType : IfcDistributionFlowElementType

		public IfcFlowSegmentType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableFitting : IfcFlowFitting

		public IfcCableFitting(){}

		public IfcCableFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableFittingType : IfcFlowFittingType

		public IfcCableFittingType(){}

		public IfcCableFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableSegment : IfcFlowSegment

		public IfcCableSegment(){}

		public IfcCableSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCableSegmentType : IfcFlowSegmentType

		public IfcCableSegmentType(){}

		public IfcCableSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianPoint : IfcPoint

		public IfcCartesianPoint(){}

		public List< IfcLengthMeasure> Coordinates;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Coordinates.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPoint : IfcGeometricRepresentationItem

		public IfcPoint(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianPointList : IfcGeometricRepresentationItem

		public IfcCartesianPointList(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianPointList3D : IfcCartesianPointList

		public IfcCartesianPointList3D(){}

		public List< List< IfcLengthMeasure>> CoordList;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			CoordList.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem

		public IfcCartesianTransformationOperator(){}

		public IfcDirection Axis1;

		[ImmediateAttribute]
		public IfcDirection Axis2;

		[ImmediateAttribute]
		public IfcCartesianPoint LocalOrigin;

		[ImmediateAttribute]
		public REAL Scale;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator

		public IfcCartesianTransformationOperator2D(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator

		public IfcCartesianTransformationOperator3D(){}

		public IfcDirection Axis3;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Axis3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis3.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D

		public IfcCartesianTransformationOperator2DnonUniform(){}

		public REAL Scale2;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Scale2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale2.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D

		public IfcCartesianTransformationOperator3DnonUniform(){}

		public REAL Scale2;

		[ImmediateAttribute]
		public REAL Scale3;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Axis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis1.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Axis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis2.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LocalOrigin == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LocalOrigin.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + LocalOrigin.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Axis3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Axis3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Axis3.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Scale2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale2.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Scale3 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale3.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale3.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcChiller : IfcEnergyConversionDevice

		public IfcChiller(){}

		public IfcChillerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcChillerType : IfcEnergyConversionDeviceType

		public IfcChillerType(){}

		public IfcChillerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCircle : IfcConic

		public IfcCircle(){}

		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Position.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConic : IfcCurve

		public IfcConic(){}

		public IfcAxis2Placement Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Position.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCircleHollowProfileDef : IfcCircleProfileDef

		public IfcCircleHollowProfileDef(){}

		public IfcPositiveLengthMeasure WallThickness;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (WallThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (WallThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ WallThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCircleProfileDef : IfcParameterizedProfileDef

		public IfcCircleProfileDef(){}

		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCivilElement : IfcElement

		public IfcCivilElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCivilElementType : IfcElementType

		public IfcCivilElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClassification : IfcExternalInformation

		public IfcClassification(){}

		public IfcLabel Source;

		[ImmediateAttribute]
		public IfcLabel Edition;

		[ImmediateAttribute]
		public IfcDate EditionDate;

		[ImmediateAttribute]
		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcURIReference Location;

		[ImmediateAttribute]
		public List< IfcIdentifier> ReferenceTokens;

		[InverseAttribute]
		public List< IfcRelAssociatesClassification> ClassificationForObjects;

		[InverseAttribute]
		public List< IfcClassificationReference> HasReferences;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Source == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Source.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Source.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Edition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Edition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Edition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EditionDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EditionDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EditionDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			ReferenceTokens.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExternalInformation : P21Instance

		public IfcExternalInformation(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClassificationReference : IfcExternalReference

		public IfcClassificationReference(){}

		public IfcClassificationReferenceSelect ReferencedSource;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcIdentifier Sort;

		[InverseAttribute]
		public List< IfcRelAssociatesClassification> ClassificationRefForObjects;

		[InverseAttribute]
		public List< IfcClassificationReference> HasReferences;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ReferencedSource.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ReferencedSource.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ReferencedSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Sort == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Sort.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Sort.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcExternalReference : P21Instance

		public IfcExternalReference(){}

		public IfcURIReference Location;

		[ImmediateAttribute]
		public IfcIdentifier Identification;

		[ImmediateAttribute]
		public IfcLabel Name;

		[InverseAttribute]
		public List< IfcExternalReferenceRelationship> ExternalReferenceForResources;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcClosedShell : IfcConnectedFaceSet

		public IfcClosedShell(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			CfsFaces.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectedFaceSet : IfcTopologicalRepresentationItem

		public IfcConnectedFaceSet(){}

		public List< IfcFace> CfsFaces;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			CfsFaces.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoil : IfcEnergyConversionDevice

		public IfcCoil(){}

		public IfcCoilTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoilType : IfcEnergyConversionDeviceType

		public IfcCoilType(){}

		public IfcCoilTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColourRgb : IfcColourSpecification

		public IfcColourRgb(){}

		public IfcNormalisedRatioMeasure Red;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure Green;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure Blue;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Red == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Red.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Red.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Green == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Green.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Green.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Blue == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Blue.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Blue.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColourSpecification : IfcPresentationItem

		public IfcColourSpecification(){}

		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColourRgbList : IfcPresentationItem

		public IfcColourRgbList(){}

		public List< List< IfcNormalisedRatioMeasure>> ColourList;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			ColourList.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPresentationItem : P21Instance

		public IfcPresentationItem(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcColumnStandardCase : IfcColumn

		public IfcColumnStandardCase(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCommunicationsAppliance : IfcFlowTerminal

		public IfcCommunicationsAppliance(){}

		public IfcCommunicationsApplianceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCommunicationsApplianceType : IfcFlowTerminalType

		public IfcCommunicationsApplianceType(){}

		public IfcCommunicationsApplianceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcComplexProperty : IfcProperty

		public IfcComplexProperty(){}

		public IfcIdentifier UsageName;

		[ImmediateAttribute]
		public List< IfcProperty> HasProperties;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UsageName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UsageName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UsageName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasProperties.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProperty : IfcPropertyAbstraction

		public IfcProperty(){}

		public IfcIdentifier Name;

		[ImmediateAttribute]
		public IfcText Description;

		[InverseAttribute]
		public List< IfcPropertySet> PartOfPset;

		[InverseAttribute]
		public List< IfcPropertyDependencyRelationship> PropertyForDependance;

		[InverseAttribute]
		public List< IfcPropertyDependencyRelationship> PropertyDependsOn;

		[InverseAttribute]
		public List< IfcComplexProperty> PartOfComplex;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcComplexPropertyTemplate : IfcPropertyTemplate

		public IfcComplexPropertyTemplate(){}

		public IfcLabel UsageName;

		[ImmediateAttribute]
		public IfcComplexPropertyTemplateTypeEnum TemplateType;

		[ImmediateAttribute]
		public List< IfcPropertyTemplate> HasPropertyTemplates;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UsageName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UsageName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UsageName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TemplateType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TemplateType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TemplateType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertyTemplates.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPropertyTemplate : IfcPropertyTemplateDefinition

		public IfcPropertyTemplate(){}

		public List< IfcComplexPropertyTemplate> PartOfComplexTemplate;

		[InverseAttribute]
		public List< IfcPropertySetTemplate> PartOfPsetTemplate;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompositeCurveSegment : IfcGeometricRepresentationItem

		public IfcCompositeCurveSegment(){}

		public IfcTransitionCode Transition;

		[ImmediateAttribute]
		public BOOLEAN SameSense;

		[ImmediateAttribute]
		public IfcCurve ParentCurve;

		[InverseAttribute]
		public List< IfcCompositeCurve> UsingCurves;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Transition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Transition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Transition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParentCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentCurve.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcReparametrisedCompositeCurveSegment : IfcCompositeCurveSegment

		public IfcReparametrisedCompositeCurveSegment(){}

		public IfcParameterValue ParamLength;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Transition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Transition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Transition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParentCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ParamLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParamLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ParamLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompositeProfileDef : IfcProfileDef

		public IfcCompositeProfileDef(){}

		public List< IfcProfileDef> Profiles;

		[ImmediateAttribute]
		public IfcLabel Label;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Profiles.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Label == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Label.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Label.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompressor : IfcFlowMovingDevice

		public IfcCompressor(){}

		public IfcCompressorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowMovingDevice : IfcDistributionFlowElement

		public IfcFlowMovingDevice(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCompressorType : IfcFlowMovingDeviceType

		public IfcCompressorType(){}

		public IfcCompressorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowMovingDeviceType : IfcDistributionFlowElementType

		public IfcFlowMovingDeviceType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCondenser : IfcEnergyConversionDevice

		public IfcCondenser(){}

		public IfcCondenserTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCondenserType : IfcEnergyConversionDeviceType

		public IfcCondenserType(){}

		public IfcCondenserTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEllipse : IfcConic

		public IfcEllipse(){}

		public IfcPositiveLengthMeasure SemiAxis1;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure SemiAxis2;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Position.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SemiAxis1 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SemiAxis1.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SemiAxis1.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SemiAxis2 == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SemiAxis2.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SemiAxis2.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOpenShell : IfcConnectedFaceSet

		public IfcOpenShell(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			CfsFaces.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTopologicalRepresentationItem : IfcRepresentationItem

		public IfcTopologicalRepresentationItem(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionCurveGeometry : IfcConnectionGeometry

		public IfcConnectionCurveGeometry(){}

		public IfcCurveOrEdgeCurve CurveOnRelatingElement;

		[ImmediateAttribute]
		public IfcCurveOrEdgeCurve CurveOnRelatedElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (CurveOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionGeometry : P21Instance

		public IfcConnectionGeometry(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionPointGeometry : IfcConnectionGeometry

		public IfcConnectionPointGeometry(){}

		public IfcPointOrVertexPoint PointOnRelatingElement;

		[ImmediateAttribute]
		public IfcPointOrVertexPoint PointOnRelatedElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (PointOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PointOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PointOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PointOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionSurfaceGeometry : IfcConnectionGeometry

		public IfcConnectionSurfaceGeometry(){}

		public IfcSurfaceOrFaceSurface SurfaceOnRelatingElement;

		[ImmediateAttribute]
		public IfcSurfaceOrFaceSurface SurfaceOnRelatedElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (SurfaceOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SurfaceOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SurfaceOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SurfaceOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SurfaceOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SurfaceOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionVolumeGeometry : IfcConnectionGeometry

		public IfcConnectionVolumeGeometry(){}

		public IfcSolidOrShell VolumeOnRelatingElement;

		[ImmediateAttribute]
		public IfcSolidOrShell VolumeOnRelatedElement;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (VolumeOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VolumeOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VolumeOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VolumeOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VolumeOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VolumeOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConnectionPointEccentricity : IfcConnectionPointGeometry

		public IfcConnectionPointEccentricity(){}

		public IfcLengthMeasure EccentricityInX;

		[ImmediateAttribute]
		public IfcLengthMeasure EccentricityInY;

		[ImmediateAttribute]
		public IfcLengthMeasure EccentricityInZ;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (PointOnRelatingElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOnRelatingElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PointOnRelatingElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PointOnRelatedElement.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PointOnRelatedElement.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PointOnRelatedElement.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EccentricityInX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EccentricityInX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EccentricityInX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EccentricityInY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EccentricityInY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EccentricityInY.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (EccentricityInZ == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EccentricityInZ.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ EccentricityInZ.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstraint : P21Instance

		public IfcConstraint(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcConstraintEnum ConstraintGrade;

		[ImmediateAttribute]
		public IfcLabel ConstraintSource;

		[ImmediateAttribute]
		public IfcActorSelect CreatingActor;

		[ImmediateAttribute]
		public IfcDateTime CreationTime;

		[ImmediateAttribute]
		public IfcLabel UserDefinedGrade;

		[InverseAttribute]
		public List< IfcExternalReferenceRelationship> HasExternalReferences;

		[InverseAttribute]
		public List< IfcResourceConstraintRelationship> PropertiesForConstraint;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreatingActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreatingActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreatingActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreationTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMetric : IfcConstraint

		public IfcMetric(){}

		public IfcBenchmarkEnum Benchmark;

		[ImmediateAttribute]
		public IfcLabel ValueSource;

		[ImmediateAttribute]
		public IfcMetricValueSelect DataValue;

		[ImmediateAttribute]
		public IfcReference ReferencePath;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreatingActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreatingActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreatingActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreationTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Benchmark == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Benchmark.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Benchmark.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ValueSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ValueSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ValueSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DataValue.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DataValue.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DataValue.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ReferencePath == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ReferencePath.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ReferencePath.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcObjective : IfcConstraint

		public IfcObjective(){}

		public List< IfcConstraint> BenchmarkValues;

		[ImmediateAttribute]
		public IfcLogicalOperatorEnum LogicalAggregator;

		[ImmediateAttribute]
		public IfcObjectiveEnum ObjectiveQualifier;

		[ImmediateAttribute]
		public IfcLabel UserDefinedQualifier;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstraintSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstraintSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstraintSource.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreatingActor.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreatingActor.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreatingActor.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreationTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedGrade == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedGrade.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedGrade.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			BenchmarkValues.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (LogicalAggregator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LogicalAggregator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LogicalAggregator.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectiveQualifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectiveQualifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectiveQualifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedQualifier == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedQualifier.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedQualifier.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionEquipmentResource : IfcConstructionResource

		public IfcConstructionEquipmentResource(){}

		public IfcConstructionEquipmentResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usage == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usage.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Usage.EIN); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionResource : IfcResource

		public IfcConstructionResource(){}

		public IfcResourceTime Usage;

		[ImmediateAttribute]
		public List< IfcAppliedValue> BaseCosts;

		[ImmediateAttribute]
		public IfcPhysicalQuantity BaseQuantity;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usage == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usage.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Usage.EIN); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionEquipmentResourceType : IfcConstructionResourceType

		public IfcConstructionEquipmentResourceType(){}

		public IfcConstructionEquipmentResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionResourceType : IfcTypeResource

		public IfcConstructionResourceType(){}

		public List< IfcAppliedValue> BaseCosts;

		[ImmediateAttribute]
		public IfcPhysicalQuantity BaseQuantity;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionMaterialResource : IfcConstructionResource

		public IfcConstructionMaterialResource(){}

		public IfcConstructionMaterialResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usage == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usage.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Usage.EIN); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionMaterialResourceType : IfcConstructionResourceType

		public IfcConstructionMaterialResourceType(){}

		public IfcConstructionMaterialResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionProductResource : IfcConstructionResource

		public IfcConstructionProductResource(){}

		public IfcConstructionProductResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usage == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usage.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Usage.EIN); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConstructionProductResourceType : IfcConstructionResourceType

		public IfcConstructionProductResourceType(){}

		public IfcConstructionProductResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCrewResource : IfcConstructionResource

		public IfcCrewResource(){}

		public IfcCrewResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usage == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usage.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Usage.EIN); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLaborResource : IfcConstructionResource

		public IfcLaborResource(){}

		public IfcLaborResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usage == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usage.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Usage.EIN); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSubContractResource : IfcConstructionResource

		public IfcSubContractResource(){}

		public IfcSubContractResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Usage == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Usage.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Usage.EIN); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcResource : IfcObject

		public IfcResource(){}

		public IfcIdentifier Identification;

		[ImmediateAttribute]
		public IfcText LongDescription;

		[InverseAttribute]
		public List< IfcRelAssignsToResource> ResourceOf;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCrewResourceType : IfcConstructionResourceType

		public IfcCrewResourceType(){}

		public IfcCrewResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLaborResourceType : IfcConstructionResourceType

		public IfcLaborResourceType(){}

		public IfcLaborResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSubContractResourceType : IfcConstructionResourceType

		public IfcSubContractResourceType(){}

		public IfcSubContractResourceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			BaseCosts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (BaseQuantity == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BaseQuantity.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BaseQuantity.EIN); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTypeResource : IfcTypeObject

		public IfcTypeResource(){}

		public IfcIdentifier Identification;

		[ImmediateAttribute]
		public IfcText LongDescription;

		[ImmediateAttribute]
		public IfcLabel ResourceType;

		[InverseAttribute]
		public List< IfcRelAssignsToResource> ResourceOf;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ResourceType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ResourceType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ResourceType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcContext : IfcObjectDefinition

		public IfcContext(){}

		public IfcLabel ObjectType;

		[ImmediateAttribute]
		public IfcLabel LongName;

		[ImmediateAttribute]
		public IfcLabel Phase;

		[ImmediateAttribute]
		public List< IfcRepresentationContext> RepresentationContexts;

		[ImmediateAttribute]
		public IfcUnitAssignment UnitsInContext;

		[InverseAttribute]
		public List< IfcRelDefinesByProperties> IsDefinedBy;

		[InverseAttribute]
		public List< IfcRelDeclares> Declares;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Phase == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Phase.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Phase.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			RepresentationContexts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (UnitsInContext == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitsInContext.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + UnitsInContext.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProject : IfcContext

		public IfcProject(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Phase == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Phase.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Phase.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			RepresentationContexts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (UnitsInContext == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitsInContext.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + UnitsInContext.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProjectLibrary : IfcContext

		public IfcProjectLibrary(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Phase == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Phase.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Phase.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			RepresentationContexts.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (UnitsInContext == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitsInContext.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + UnitsInContext.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcObjectDefinition : IfcRoot

		public IfcObjectDefinition(){}

		public List< IfcRelAssigns> HasAssignments;

		[InverseAttribute]
		public List< IfcRelNests> Nests;

		[InverseAttribute]
		public List< IfcRelNests> IsNestedBy;

		[InverseAttribute]
		public List< IfcRelDeclares> HasContext;

		[InverseAttribute]
		public List< IfcRelAggregates> IsDecomposedBy;

		[InverseAttribute]
		public List< IfcRelAggregates> Decomposes;

		[InverseAttribute]
		public List< IfcRelAssociates> HasAssociations;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcContextDependentUnit : IfcNamedUnit

		public IfcContextDependentUnit(){}

		public IfcLabel Name;

		[InverseAttribute]
		public List< IfcExternalReferenceRelationship> HasExternalReference;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Dimensions == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dimensions.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dimensions.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcNamedUnit : P21Instance

		public IfcNamedUnit(){}

		public IfcDimensionalExponents Dimensions;

		[ImmediateAttribute]
		public IfcUnitEnum UnitType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Dimensions == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dimensions.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dimensions.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCostItem : IfcControl

		public IfcCostItem(){}

		public IfcCostItemTypeEnum PredefinedType;

		[ImmediateAttribute]
		public List< IfcCostValue> CostValues;

		[ImmediateAttribute]
		public List< IfcPhysicalQuantity> CostQuantities;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			CostValues.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			CostQuantities.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCostSchedule : IfcControl

		public IfcCostSchedule(){}

		public IfcCostScheduleTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcLabel Status;

		[ImmediateAttribute]
		public IfcDateTime SubmittedOn;

		[ImmediateAttribute]
		public IfcDateTime UpdateDate;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SubmittedOn == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SubmittedOn.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SubmittedOn.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UpdateDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UpdateDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UpdateDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPerformanceHistory : IfcControl

		public IfcPerformanceHistory(){}

		public IfcLabel LifeCyclePhase;

		[ImmediateAttribute]
		public IfcPerformanceHistoryTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LifeCyclePhase == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LifeCyclePhase.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LifeCyclePhase.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPermit : IfcControl

		public IfcPermit(){}

		public IfcPermitTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcLabel Status;

		[ImmediateAttribute]
		public IfcText LongDescription;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProjectOrder : IfcControl

		public IfcProjectOrder(){}

		public IfcProjectOrderTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcLabel Status;

		[ImmediateAttribute]
		public IfcText LongDescription;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongDescription == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongDescription.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongDescription.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWorkCalendar : IfcControl

		public IfcWorkCalendar(){}

		public List< IfcWorkTime> WorkingTimes;

		[ImmediateAttribute]
		public List< IfcWorkTime> ExceptionTimes;

		[ImmediateAttribute]
		public IfcWorkCalendarTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			WorkingTimes.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			ExceptionTimes.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcWorkControl : IfcControl

		public IfcWorkControl(){}

		public IfcDateTime CreationDate;

		[ImmediateAttribute]
		public List< IfcPerson> Creators;

		[ImmediateAttribute]
		public IfcLabel Purpose;

		[ImmediateAttribute]
		public IfcDuration Duration;

		[ImmediateAttribute]
		public IfcDuration TotalFloat;

		[ImmediateAttribute]
		public IfcDateTime StartTime;

		[ImmediateAttribute]
		public IfcDateTime FinishTime;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CreationDate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationDate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationDate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Creators.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Duration == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Duration.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Duration.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TotalFloat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TotalFloat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TotalFloat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (StartTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (StartTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ StartTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (FinishTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FinishTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FinishTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcController : IfcDistributionControlElement

		public IfcController(){}

		public IfcControllerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcControllerType : IfcDistributionControlElementType

		public IfcControllerType(){}

		public IfcControllerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConversionBasedUnit : IfcNamedUnit

		public IfcConversionBasedUnit(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcMeasureWithUnit ConversionFactor;

		[InverseAttribute]
		public List< IfcExternalReferenceRelationship> HasExternalReference;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Dimensions == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dimensions.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dimensions.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConversionFactor == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConversionFactor.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ConversionFactor.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcConversionBasedUnitWithOffset : IfcConversionBasedUnit

		public IfcConversionBasedUnitWithOffset(){}

		public IfcReal ConversionOffset;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Dimensions == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dimensions.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dimensions.EIN); }
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConversionFactor == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConversionFactor.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ConversionFactor.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ConversionOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConversionOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConversionOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCooledBeam : IfcEnergyConversionDevice

		public IfcCooledBeam(){}

		public IfcCooledBeamTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCooledBeamType : IfcEnergyConversionDeviceType

		public IfcCooledBeamType(){}

		public IfcCooledBeamTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoolingTower : IfcEnergyConversionDevice

		public IfcCoolingTower(){}

		public IfcCoolingTowerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoolingTowerType : IfcEnergyConversionDeviceType

		public IfcCoolingTowerType(){}

		public IfcCoolingTowerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoordinateOperation : P21Instance

		public IfcCoordinateOperation(){}

		public IfcCoordinateReferenceSystemSelect SourceCRS;

		[ImmediateAttribute]
		public IfcCoordinateReferenceSystem TargetCRS;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (SourceCRS.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SourceCRS.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SourceCRS.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TargetCRS == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TargetCRS.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TargetCRS.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMapConversion : IfcCoordinateOperation

		public IfcMapConversion(){}

		public IfcLengthMeasure Eastings;

		[ImmediateAttribute]
		public IfcLengthMeasure Northings;

		[ImmediateAttribute]
		public IfcLengthMeasure OrthogonalHeight;

		[ImmediateAttribute]
		public IfcReal XAxisAbscissa;

		[ImmediateAttribute]
		public IfcReal XAxisOrdinate;

		[ImmediateAttribute]
		public IfcReal Scale;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (SourceCRS.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SourceCRS.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SourceCRS.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TargetCRS == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TargetCRS.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + TargetCRS.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Eastings == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Eastings.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Eastings.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Northings == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Northings.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Northings.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OrthogonalHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OrthogonalHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OrthogonalHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (XAxisAbscissa == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (XAxisAbscissa.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ XAxisAbscissa.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (XAxisOrdinate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (XAxisOrdinate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ XAxisOrdinate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Scale == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scale.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scale.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCoordinateReferenceSystem : P21Instance

		public IfcCoordinateReferenceSystem(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcIdentifier GeodeticDatum;

		[ImmediateAttribute]
		public IfcIdentifier VerticalDatum;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (GeodeticDatum == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GeodeticDatum.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GeodeticDatum.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VerticalDatum == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VerticalDatum.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VerticalDatum.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProjectedCRS : IfcCoordinateReferenceSystem

		public IfcProjectedCRS(){}

		public IfcIdentifier MapProjection;

		[ImmediateAttribute]
		public IfcIdentifier MapZone;

		[ImmediateAttribute]
		public IfcNamedUnit MapUnit;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (GeodeticDatum == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GeodeticDatum.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GeodeticDatum.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (VerticalDatum == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VerticalDatum.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VerticalDatum.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MapProjection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MapProjection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MapProjection.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MapZone == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MapZone.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MapZone.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MapUnit == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MapUnit.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + MapUnit.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRectangularPyramid : IfcCsgPrimitive3D

		public IfcRectangularPyramid(){}

		public IfcPositiveLengthMeasure XLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure YLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Height;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (XLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (XLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ XLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (YLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (YLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ YLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Height == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Height.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Height.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRightCircularCone : IfcCsgPrimitive3D

		public IfcRightCircularCone(){}

		public IfcPositiveLengthMeasure Height;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure BottomRadius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Height == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Height.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Height.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (BottomRadius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BottomRadius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ BottomRadius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcRightCircularCylinder : IfcCsgPrimitive3D

		public IfcRightCircularCylinder(){}

		public IfcPositiveLengthMeasure Height;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Height == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Height.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Height.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSphere : IfcCsgPrimitive3D

		public IfcSphere(){}

		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCsgSolid : IfcSolidModel

		public IfcCsgSolid(){}

		public IfcCsgSelect TreeRootExpression;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (TreeRootExpression.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TreeRootExpression.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TreeRootExpression.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSolidModel : IfcGeometricRepresentationItem

		public IfcSolidModel(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurrencyRelationship : IfcResourceLevelRelationship

		public IfcCurrencyRelationship(){}

		public IfcMonetaryUnit RelatingMonetaryUnit;

		[ImmediateAttribute]
		public IfcMonetaryUnit RelatedMonetaryUnit;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure ExchangeRate;

		[ImmediateAttribute]
		public IfcDateTime RateDateTime;

		[ImmediateAttribute]
		public IfcLibraryInformation RateSource;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RelatingMonetaryUnit == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingMonetaryUnit.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingMonetaryUnit.EIN); }
			p21File.Write(EbConstants.Comma);
			if (RelatedMonetaryUnit == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatedMonetaryUnit.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatedMonetaryUnit.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ExchangeRate == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ExchangeRate.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ExchangeRate.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RateDateTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RateDateTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RateDateTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RateSource == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RateSource.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RateSource.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLine : IfcCurve

		public IfcLine(){}

		public IfcCartesianPoint Pnt;

		[ImmediateAttribute]
		public IfcVector Dir;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Pnt == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Pnt.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Pnt.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Dir == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Dir.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Dir.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOffsetCurve2D : IfcCurve

		public IfcOffsetCurve2D(){}

		public IfcCurve BasisCurve;

		[ImmediateAttribute]
		public IfcLengthMeasure Distance;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Distance == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Distance.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Distance.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOffsetCurve3D : IfcCurve

		public IfcOffsetCurve3D(){}

		public IfcCurve BasisCurve;

		[ImmediateAttribute]
		public IfcLengthMeasure Distance;

		[ImmediateAttribute]
		public LOGICAL SelfIntersect;

		[ImmediateAttribute]
		public IfcDirection RefDirection;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisCurve.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Distance == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Distance.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Distance.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SelfIntersect == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SelfIntersect.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SelfIntersect.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RefDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RefDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RefDirection.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPcurve : IfcCurve

		public IfcPcurve(){}

		public IfcSurface BasisSurface;

		[ImmediateAttribute]
		public IfcCurve ReferenceCurve;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (BasisSurface == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (BasisSurface.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + BasisSurface.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ReferenceCurve == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ReferenceCurve.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ReferenceCurve.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveStyle : IfcPresentationStyle

		public IfcCurveStyle(){}

		public IfcCurveFontOrScaledCurveFontSelect CurveFont;

		[ImmediateAttribute]
		public IfcSizeSelect CurveWidth;

		[ImmediateAttribute]
		public IfcColour CurveColour;

		[ImmediateAttribute]
		public BOOLEAN ModelOrDraughting;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveFont.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveFont.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveFont.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveWidth.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveWidth.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveColour.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveColour.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveColour.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ModelOrDraughting == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ModelOrDraughting.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ModelOrDraughting.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPresentationStyle : P21Instance

		public IfcPresentationStyle(){}

		public IfcLabel Name;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveStyleFont : IfcPresentationItem

		public IfcCurveStyleFont(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public List< IfcCurveStyleFontPattern> PatternList;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			PatternList.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveStyleFontAndScaling : IfcPresentationItem

		public IfcCurveStyleFontAndScaling(){}

		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcCurveStyleFontSelect CurveFont;

		[ImmediateAttribute]
		public IfcPositiveRatioMeasure CurveFontScaling;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveFont.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveFont.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveFont.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CurveFontScaling == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CurveFontScaling.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CurveFontScaling.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCurveStyleFontPattern : IfcPresentationItem

		public IfcCurveStyleFontPattern(){}

		public IfcLengthMeasure VisibleSegmentLength;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure InvisibleSegmentLength;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (VisibleSegmentLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (VisibleSegmentLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ VisibleSegmentLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (InvisibleSegmentLength == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (InvisibleSegmentLength.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ InvisibleSegmentLength.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcCylindricalSurface : IfcElementarySurface

		public IfcCylindricalSurface(){}

		public IfcPositiveLengthMeasure Radius;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Radius == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Radius.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Radius.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementarySurface : IfcSurface

		public IfcElementarySurface(){}

		public IfcAxis2Placement3D Position;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Position == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Position.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Position.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDamper : IfcFlowController

		public IfcDamper(){}

		public IfcDamperTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDamperType : IfcFlowControllerType

		public IfcDamperType(){}

		public IfcDamperTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDerivedProfileDef : IfcProfileDef

		public IfcDerivedProfileDef(){}

		public IfcProfileDef ParentProfile;

		[ImmediateAttribute]
		public IfcCartesianTransformationOperator2D Operator;

		[ImmediateAttribute]
		public IfcLabel Label;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParentProfile == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentProfile.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentProfile.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Operator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Operator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Operator.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Label == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Label.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Label.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcMirroredProfileDef : IfcDerivedProfileDef

		public IfcMirroredProfileDef(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (ProfileType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ProfileName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ProfileName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ProfileName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParentProfile == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentProfile.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentProfile.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Operator == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Operator.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Operator.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Label == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Label.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Label.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDerivedUnit : P21Instance

		public IfcDerivedUnit(){}

		public List< IfcDerivedUnitElement> Elements;

		[ImmediateAttribute]
		public IfcDerivedUnitEnum UnitType;

		[ImmediateAttribute]
		public IfcLabel UserDefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			Elements.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (UnitType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UnitType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UnitType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDerivedUnitElement : P21Instance

		public IfcDerivedUnitElement(){}

		public IfcNamedUnit Unit;

		[ImmediateAttribute]
		public INTEGER Exponent;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Unit == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Unit.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Unit.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Exponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Exponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Exponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDimensionalExponents : P21Instance

		public IfcDimensionalExponents(){}

		public INTEGER LengthExponent;

		[ImmediateAttribute]
		public INTEGER MassExponent;

		[ImmediateAttribute]
		public INTEGER TimeExponent;

		[ImmediateAttribute]
		public INTEGER ElectricCurrentExponent;

		[ImmediateAttribute]
		public INTEGER ThermodynamicTemperatureExponent;

		[ImmediateAttribute]
		public INTEGER AmountOfSubstanceExponent;

		[ImmediateAttribute]
		public INTEGER LuminousIntensityExponent;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (LengthExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LengthExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LengthExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (MassExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (MassExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ MassExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TimeExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TimeExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TimeExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElectricCurrentExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElectricCurrentExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElectricCurrentExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ThermodynamicTemperatureExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ThermodynamicTemperatureExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ThermodynamicTemperatureExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AmountOfSubstanceExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AmountOfSubstanceExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AmountOfSubstanceExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LuminousIntensityExponent == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LuminousIntensityExponent.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LuminousIntensityExponent.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDirection : IfcGeometricRepresentationItem

		public IfcDirection(){}

		public List< REAL> DirectionRatios;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			DirectionRatios.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDiscreteAccessory : IfcElementComponent

		public IfcDiscreteAccessory(){}

		public IfcDiscreteAccessoryTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDiscreteAccessoryType : IfcElementComponentType

		public IfcDiscreteAccessoryType(){}

		public IfcDiscreteAccessoryTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionChamberElement : IfcDistributionFlowElement

		public IfcDistributionChamberElement(){}

		public IfcDistributionChamberElementTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionFlowElement : IfcDistributionElement

		public IfcDistributionFlowElement(){}

		public List< IfcRelFlowControlElements> HasControlElements;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionChamberElementType : IfcDistributionFlowElementType

		public IfcDistributionChamberElementType(){}

		public IfcDistributionChamberElementTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionFlowElementType : IfcDistributionElementType

		public IfcDistributionFlowElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionCircuit : IfcDistributionSystem

		public IfcDistributionCircuit(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionSystem : IfcSystem

		public IfcDistributionSystem(){}

		public IfcLabel LongName;

		[ImmediateAttribute]
		public IfcDistributionSystemEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LongName == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LongName.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LongName.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowInstrument : IfcDistributionControlElement

		public IfcFlowInstrument(){}

		public IfcFlowInstrumentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProtectiveDeviceTrippingUnit : IfcDistributionControlElement

		public IfcProtectiveDeviceTrippingUnit(){}

		public IfcProtectiveDeviceTrippingUnitTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSensor : IfcDistributionControlElement

		public IfcSensor(){}

		public IfcSensorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcUnitaryControlElement : IfcDistributionControlElement

		public IfcUnitaryControlElement(){}

		public IfcUnitaryControlElementTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionElement : IfcElement

		public IfcDistributionElement(){}

		public List< IfcRelConnectsPortToElement> HasPorts;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowInstrumentType : IfcDistributionControlElementType

		public IfcFlowInstrumentType(){}

		public IfcFlowInstrumentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcProtectiveDeviceTrippingUnitType : IfcDistributionControlElementType

		public IfcProtectiveDeviceTrippingUnitType(){}

		public IfcProtectiveDeviceTrippingUnitTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSensorType : IfcDistributionControlElementType

		public IfcSensorType(){}

		public IfcSensorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcUnitaryControlElementType : IfcDistributionControlElementType

		public IfcUnitaryControlElementType(){}

		public IfcUnitaryControlElementTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionElementType : IfcElementType

		public IfcDistributionElementType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowStorageDevice : IfcDistributionFlowElement

		public IfcFlowStorageDevice(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowTreatmentDevice : IfcDistributionFlowElement

		public IfcFlowTreatmentDevice(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowStorageDeviceType : IfcDistributionFlowElementType

		public IfcFlowStorageDeviceType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFlowTreatmentDeviceType : IfcDistributionFlowElementType

		public IfcFlowTreatmentDeviceType(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDistributionPort : IfcPort

		public IfcDistributionPort(){}

		public IfcFlowDirectionEnum FlowDirection;

		[ImmediateAttribute]
		public IfcDistributionPortTypeEnum PredefinedType;

		[ImmediateAttribute]
		public IfcDistributionSystemEnum SystemType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (FlowDirection == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (FlowDirection.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ FlowDirection.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (SystemType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SystemType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SystemType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPort : IfcProduct

		public IfcPort(){}

		public List< IfcRelConnectsPortToElement> ContainedIn;

		[InverseAttribute]
		public List< IfcRelConnectsPorts> ConnectedFrom;

		[InverseAttribute]
		public List< IfcRelConnectsPorts> ConnectedTo;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDocumentInformation : IfcExternalInformation

		public IfcDocumentInformation(){}

		public IfcIdentifier Identification;

		[ImmediateAttribute]
		public IfcLabel Name;

		[ImmediateAttribute]
		public IfcText Description;

		[ImmediateAttribute]
		public IfcURIReference Location;

		[ImmediateAttribute]
		public IfcText Purpose;

		[ImmediateAttribute]
		public IfcText IntendedUse;

		[ImmediateAttribute]
		public IfcText Scope;

		[ImmediateAttribute]
		public IfcLabel Revision;

		[ImmediateAttribute]
		public IfcActorSelect DocumentOwner;

		[ImmediateAttribute]
		public List< IfcActorSelect> Editors;

		[ImmediateAttribute]
		public IfcDateTime CreationTime;

		[ImmediateAttribute]
		public IfcDateTime LastRevisionTime;

		[ImmediateAttribute]
		public IfcIdentifier ElectronicFormat;

		[ImmediateAttribute]
		public IfcDate ValidFrom;

		[ImmediateAttribute]
		public IfcDate ValidUntil;

		[ImmediateAttribute]
		public IfcDocumentConfidentialityEnum Confidentiality;

		[ImmediateAttribute]
		public IfcDocumentStatusEnum Status;

		[InverseAttribute]
		public List< IfcRelAssociatesDocument> DocumentInfoForObjects;

		[InverseAttribute]
		public List< IfcDocumentReference> HasDocumentReferences;

		[InverseAttribute]
		public List< IfcDocumentInformationRelationship> IsPointedTo;

		[InverseAttribute]
		public List< IfcDocumentInformationRelationship> IsPointer;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Purpose == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Purpose.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Purpose.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (IntendedUse == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (IntendedUse.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ IntendedUse.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Scope == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Scope.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Scope.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Revision == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Revision.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Revision.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (DocumentOwner.Value == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (DocumentOwner.Value.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ DocumentOwner.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			Editors.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (CreationTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CreationTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CreationTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LastRevisionTime == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LastRevisionTime.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LastRevisionTime.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElectronicFormat == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElectronicFormat.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElectronicFormat.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ValidFrom == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ValidFrom.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ValidFrom.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ValidUntil == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ValidUntil.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ValidUntil.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Confidentiality == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Confidentiality.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Confidentiality.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Status == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Status.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Status.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDocumentInformationRelationship : IfcResourceLevelRelationship

		public IfcDocumentInformationRelationship(){}

		public IfcDocumentInformation RelatingDocument;

		[ImmediateAttribute]
		public List< IfcDocumentInformation> RelatedDocuments;

		[ImmediateAttribute]
		public IfcLabel RelationshipType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (RelatingDocument == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelatingDocument.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + RelatingDocument.EIN); }
			p21File.Write(EbConstants.Comma);
			RelatedDocuments.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (RelationshipType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (RelationshipType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ RelationshipType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDocumentReference : IfcExternalReference

		public IfcDocumentReference(){}

		public IfcText Description;

		[ImmediateAttribute]
		public IfcDocumentInformation ReferencedDocument;

		[InverseAttribute]
		public List< IfcRelAssociatesDocument> DocumentRefForObjects;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Location == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Location.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Location.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Identification == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Identification.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Identification.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ReferencedDocument == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ReferencedDocument.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ReferencedDocument.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoorStandardCase : IfcDoor

		public IfcDoorStandardCase(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallHeight == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallHeight.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallHeight.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OverallWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OverallWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OverallWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (UserDefinedOperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (UserDefinedOperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ UserDefinedOperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoorLiningProperties : IfcPreDefinedPropertySet

		public IfcDoorLiningProperties(){}

		public IfcPositiveLengthMeasure LiningDepth;

		[ImmediateAttribute]
		public IfcNonNegativeLengthMeasure LiningThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure ThresholdDepth;

		[ImmediateAttribute]
		public IfcNonNegativeLengthMeasure ThresholdThickness;

		[ImmediateAttribute]
		public IfcNonNegativeLengthMeasure TransomThickness;

		[ImmediateAttribute]
		public IfcLengthMeasure TransomOffset;

		[ImmediateAttribute]
		public IfcLengthMeasure LiningOffset;

		[ImmediateAttribute]
		public IfcLengthMeasure ThresholdOffset;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CasingThickness;

		[ImmediateAttribute]
		public IfcPositiveLengthMeasure CasingDepth;

		[ImmediateAttribute]
		public IfcShapeAspect ShapeAspectStyle;

		[ImmediateAttribute]
		public IfcLengthMeasure LiningToPanelOffsetX;

		[ImmediateAttribute]
		public IfcLengthMeasure LiningToPanelOffsetY;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LiningDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LiningDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LiningDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LiningThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LiningThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LiningThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ThresholdDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ThresholdDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ThresholdDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ThresholdThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ThresholdThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ThresholdThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TransomThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TransomThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TransomThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (TransomOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (TransomOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ TransomOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LiningOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LiningOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LiningOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ThresholdOffset == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ThresholdOffset.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ThresholdOffset.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CasingThickness == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CasingThickness.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CasingThickness.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (CasingDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (CasingDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ CasingDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShapeAspectStyle == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShapeAspectStyle.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ShapeAspectStyle.EIN); }
			p21File.Write(EbConstants.Comma);
			if (LiningToPanelOffsetX == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LiningToPanelOffsetX.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LiningToPanelOffsetX.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (LiningToPanelOffsetY == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (LiningToPanelOffsetY.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ LiningToPanelOffsetY.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPreDefinedPropertySet : IfcPropertySetDefinition

		public IfcPreDefinedPropertySet(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoorPanelProperties : IfcPreDefinedPropertySet

		public IfcDoorPanelProperties(){}

		public IfcPositiveLengthMeasure PanelDepth;

		[ImmediateAttribute]
		public IfcDoorPanelOperationEnum PanelOperation;

		[ImmediateAttribute]
		public IfcNormalisedRatioMeasure PanelWidth;

		[ImmediateAttribute]
		public IfcDoorPanelPositionEnum PanelPosition;

		[ImmediateAttribute]
		public IfcShapeAspect ShapeAspectStyle;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PanelDepth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PanelDepth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PanelDepth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PanelOperation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PanelOperation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PanelOperation.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PanelWidth == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PanelWidth.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PanelWidth.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PanelPosition == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PanelPosition.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PanelPosition.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ShapeAspectStyle == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ShapeAspectStyle.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ShapeAspectStyle.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDoorStyle : IfcTypeProduct

		public IfcDoorStyle(){}

		public IfcDoorStyleOperationEnum OperationType;

		[ImmediateAttribute]
		public IfcDoorStyleConstructionEnum ConstructionType;

		[ImmediateAttribute]
		public BOOLEAN ParameterTakesPrecedence;

		[ImmediateAttribute]
		public BOOLEAN Sizeable;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OperationType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OperationType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ OperationType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ConstructionType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ConstructionType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ConstructionType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ParameterTakesPrecedence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParameterTakesPrecedence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ParameterTakesPrecedence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Sizeable == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Sizeable.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Sizeable.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTypeProduct : IfcTypeObject

		public IfcTypeProduct(){}

		public List< IfcRepresentationMap> RepresentationMaps;

		[ImmediateAttribute]
		public IfcLabel Tag;

		[InverseAttribute]
		public List< IfcRelAssignsToProduct> ReferencedBy;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDraughtingPreDefinedColour : IfcPreDefinedColour

		public IfcDraughtingPreDefinedColour(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPreDefinedColour : IfcPreDefinedItem

		public IfcPreDefinedColour(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDraughtingPreDefinedCurveFont : IfcPreDefinedCurveFont

		public IfcDraughtingPreDefinedCurveFont(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcPreDefinedCurveFont : IfcPreDefinedItem

		public IfcPreDefinedCurveFont(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctFitting : IfcFlowFitting

		public IfcDuctFitting(){}

		public IfcDuctFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctFittingType : IfcFlowFittingType

		public IfcDuctFittingType(){}

		public IfcDuctFittingTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctSegment : IfcFlowSegment

		public IfcDuctSegment(){}

		public IfcDuctSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctSegmentType : IfcFlowSegmentType

		public IfcDuctSegmentType(){}

		public IfcDuctSegmentTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctSilencer : IfcFlowTreatmentDevice

		public IfcDuctSilencer(){}

		public IfcDuctSilencerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcDuctSilencerType : IfcFlowTreatmentDeviceType

		public IfcDuctSilencerType(){}

		public IfcDuctSilencerTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEdge : IfcTopologicalRepresentationItem

		public IfcEdge(){}

		public IfcVertex EdgeStart;

		[ImmediateAttribute]
		public IfcVertex EdgeEnd;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (EdgeStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeEnd == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeEnd.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeEnd.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEdgeCurve : IfcEdge

		public IfcEdgeCurve(){}

		public IfcCurve EdgeGeometry;

		[ImmediateAttribute]
		public BOOLEAN SameSense;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (EdgeStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeEnd == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeEnd.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeEnd.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeGeometry == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeGeometry.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeGeometry.EIN); }
			p21File.Write(EbConstants.Comma);
			if (SameSense == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (SameSense.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ SameSense.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcOrientedEdge : IfcEdge

		public IfcOrientedEdge(){}

		public IfcEdge EdgeElement;

		[ImmediateAttribute]
		public BOOLEAN Orientation;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (EdgeStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeEnd == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeEnd.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeEnd.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeElement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeElement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeElement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Orientation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Orientation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Orientation.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcSubedge : IfcEdge

		public IfcSubedge(){}

		public IfcEdge ParentEdge;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (EdgeStart == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeStart.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeStart.EIN); }
			p21File.Write(EbConstants.Comma);
			if (EdgeEnd == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (EdgeEnd.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + EdgeEnd.EIN); }
			p21File.Write(EbConstants.Comma);
			if (ParentEdge == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ParentEdge.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ParentEdge.EIN); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcEdgeLoop : IfcLoop

		public IfcEdgeLoop(){}

		public List< IfcOrientedEdge> EdgeList;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			EdgeList.WriteToP21(p21File);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcLoop : IfcTopologicalRepresentationItem

		public IfcLoop(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricAppliance : IfcFlowTerminal

		public IfcElectricAppliance(){}

		public IfcElectricApplianceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricApplianceType : IfcFlowTerminalType

		public IfcElectricApplianceType(){}

		public IfcElectricApplianceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricDistributionBoard : IfcFlowController

		public IfcElectricDistributionBoard(){}

		public IfcElectricDistributionBoardTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricDistributionBoardType : IfcFlowControllerType

		public IfcElectricDistributionBoardType(){}

		public IfcElectricDistributionBoardTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricFlowStorageDevice : IfcFlowStorageDevice

		public IfcElectricFlowStorageDevice(){}

		public IfcElectricFlowStorageDeviceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricFlowStorageDeviceType : IfcFlowStorageDeviceType

		public IfcElectricFlowStorageDeviceType(){}

		public IfcElectricFlowStorageDeviceTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricGenerator : IfcEnergyConversionDevice

		public IfcElectricGenerator(){}

		public IfcElectricGeneratorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricGeneratorType : IfcEnergyConversionDeviceType

		public IfcElectricGeneratorType(){}

		public IfcElectricGeneratorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricMotor : IfcEnergyConversionDevice

		public IfcElectricMotor(){}

		public IfcElectricMotorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricMotorType : IfcEnergyConversionDeviceType

		public IfcElectricMotorType(){}

		public IfcElectricMotorTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricTimeControl : IfcFlowController

		public IfcElectricTimeControl(){}

		public IfcElectricTimeControlTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElectricTimeControlType : IfcFlowControllerType

		public IfcElectricTimeControlType(){}

		public IfcElectricTimeControlTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ApplicableOccurrence == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ApplicableOccurrence.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ApplicableOccurrence.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			HasPropertySets.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			RepresentationMaps.WriteToP21(p21File);
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ElementType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ElementType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ElementType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementAssembly : IfcElement

		public IfcElementAssembly(){}

		public IfcAssemblyPlaceEnum AssemblyPlace;

		[ImmediateAttribute]
		public IfcElementAssemblyTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (AssemblyPlace == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (AssemblyPlace.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ AssemblyPlace.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFeatureElement : IfcElement

		public IfcFeatureElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcFurnishingElement : IfcElement

		public IfcFurnishingElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcGeographicElement : IfcElement

		public IfcGeographicElement(){}

		public IfcGeographicElementTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcTransportElement : IfcElement

		public IfcTransportElement(){}

		public IfcTransportElementTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (PredefinedType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (PredefinedType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ PredefinedType.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcVirtualElement : IfcElement

		public IfcVirtualElement(){}

		{
			p21File.Write(GetType().Name.ToUpper());
			p21File.Write(EbConstants.LParentheses);
			if (GlobalId == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (GlobalId.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ GlobalId.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (OwnerHistory == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (OwnerHistory.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + OwnerHistory.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Name == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Name.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Name.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (Description == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Description.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Description.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectType == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectType.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ ObjectType.WriteToP21(p21File); }
			p21File.Write(EbConstants.Comma);
			if (ObjectPlacement == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (ObjectPlacement.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + ObjectPlacement.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Representation == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Representation.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ p21File.Write("#" + Representation.EIN); }
			p21File.Write(EbConstants.Comma);
			if (Tag == null)
			{ p21File.Write(EbConstants.Dollar); }
			else if (Tag.IsDerived)
			{ p21File.Write(EbConstants.Asterisk); }
			else
			{ Tag.WriteToP21(p21File); }
			p21File.Write(EbConstants.RParentheses);
		}
	}

	public partial class IfcElementAssemblyType : IfcElementType

		public IfcElementAssemblyType(){}

		public IfcElementAssemblyTypeEnum PredefinedType;

		public override void WriteToP21(StreamWriter p21File)
		{
			p21File.Write(GetType().Name.ToUpper());
