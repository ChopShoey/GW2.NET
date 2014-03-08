﻿using GW2DotNET.V1.Core.Drawing;
using GW2DotNET.V1.Core.DynamicEventsInformation.Details.Locations;
using Newtonsoft.Json;
using NUnit.Framework;

namespace GW2DotNET.Core.DynamicEventsInformation.Details.Locations
{
    [TestFixture]
    public class SphereLocationTest
    {
        [SetUp]
        public void Initialize()
        {
            const string input = "{\"type\":\"sphere\",\"center\":[],\"radius\":0,\"rotation\":0}";
            this.sphereLocation = JsonConvert.DeserializeObject<SphereLocation>(input);
        }

        private SphereLocation sphereLocation;

        [Test]
        [Category("event_details.json")]
        public void SphereLocation_CenterReflectsInput()
        {
            Point3D expected = default(Point3D);
            Point3D actual = this.sphereLocation.Center;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("event_details.json")]
        [Category("ExtensionData")]
        public void SphereLocation_ExtensionDataIsEmpty()
        {
            Assert.IsEmpty(this.sphereLocation.ExtensionData);
        }

        [Test]
        [Category("event_details.json")]
        public void SphereLocation_RadiusReflectsInput()
        {
            const double expected = default(double);
            double actual = this.sphereLocation.Radius;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("event_details.json")]
        public void SphereLocation_RotationReflectsInput()
        {
            const double expected = default(double);
            double actual = this.sphereLocation.Rotation;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("event_details.json")]
        public void SphereLocation_TypeReflectsInput()
        {
            const LocationType expected = LocationType.Sphere;
            LocationType actual = this.sphereLocation.Type;

            Assert.AreEqual(expected, actual);
        }
    }
}