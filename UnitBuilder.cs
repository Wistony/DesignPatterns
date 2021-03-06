﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_CreationalPatterns
{
    public abstract class UnitBuilder
    {
        public Unit Unit { get; private set; }
        public void CreateBuilder()
        {
            Unit = new Unit();
        }
        public abstract void SetMovement();
        public abstract void SetWeapon();
        public abstract void SetType();
        public abstract void SetHealth();
    }

    public class InfantryBuilder : UnitBuilder
    {
        public override void SetMovement()
        {
            this.Unit.MovementLogic = new RunMovement();
        }

        public override void SetWeapon()
        {
            this.Unit.Weapon = new Rifle();
        }

        public override void SetType()
        {
            this.Unit.Type = "Infantry";
        }

        public override void SetHealth()
        {
            this.Unit.StartHealth = this.Unit.HealthLeft = 300; 
        }
    }

    public class ShooterBuilder : UnitBuilder
    {
        public override void SetMovement()
        {
            this.Unit.MovementLogic = new RunMovement();
        }

        public override void SetWeapon()
        {
            this.Unit.Weapon = new SniperRifle();
        }

        public override void SetType()
        {
            this.Unit.Type = "Shooter";
        }

        public override void SetHealth()
        {
            this.Unit.StartHealth = this.Unit.HealthLeft = 200;
        }
    }

    public class CavalryBuilder : UnitBuilder
    {
        public override void SetMovement()
        {
            this.Unit.MovementLogic = new JumpMovement();
        }

        public override void SetWeapon()
        {
            this.Unit.Weapon = new Sword();
        }

        public override void SetType()
        {
            this.Unit.Type = "Cavalry";
        }

        public override void SetHealth()
        {
            this.Unit.StartHealth = this.Unit.HealthLeft = 350;
        }
    }

    public class TankBuilder : UnitBuilder
    {
        public override void SetMovement()
        {
            this.Unit.MovementLogic = new RideMovement();
        }

        public override void SetWeapon()
        {
            this.Unit.Weapon = new TankGun();
        }

        public override void SetType()
        {
            this.Unit.Type = "Tank";
        }

        public override void SetHealth()
        {
            this.Unit.StartHealth = this.Unit.HealthLeft = 450;
        }
    }

    public class PlaneBuilder : UnitBuilder
    {
        public override void SetMovement()
        {
            this.Unit.MovementLogic = new FlyMovement();
        }

        public override void SetWeapon()
        {
            this.Unit.Weapon = new MachineGun();
        }

        public override void SetType()
        {
            this.Unit.Type = "Plane";
        }

        public override void SetHealth()
        {
            this.Unit.StartHealth = this.Unit.HealthLeft = 425;
        }
    }

}
