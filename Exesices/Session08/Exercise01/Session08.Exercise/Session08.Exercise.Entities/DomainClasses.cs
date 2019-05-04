using System;
using System.Collections.Generic;
using System.Text;

namespace Session08.Exercise.Domain
{
    public class Parent
    {
        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Child01> Child01s { get; set; }
        public Child02 Child02 { get; set; }
    }
    public class Child01
    {
        public int Child01Id { get; set; }
        public string Description { get; set; }

        public int ParentId { get; set; }
        public Parent Parent { get; set; }
    }
    public class Child02
    {
        public int Child02Id { get; set; }
        public string Description { get; set; }

        public int ParentId { get; set; }
        public Parent Parent { get; set; }
    }


    public class EntityInAnotherContext
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
