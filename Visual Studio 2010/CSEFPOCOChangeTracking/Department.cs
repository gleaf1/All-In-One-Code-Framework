//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CSEFPOCOChangeTracking
{
    public partial class Department
    {
        #region Primitive Properties
    
        public virtual int DepartmentID
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual Nullable<decimal> Budget
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }
    
        public virtual Nullable<int> Administrator
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Course> Courses
        {
            get
            {
                if (_courses == null)
                {
                    var newCollection = new FixupCollection<Course>();
                    newCollection.CollectionChanged += FixupCourses;
                    _courses = newCollection;
                }
                return _courses;
            }
            set
            {
                if (!ReferenceEquals(_courses, value))
                {
                    var previousValue = _courses as FixupCollection<Course>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCourses;
                    }
                    _courses = value;
                    var newValue = value as FixupCollection<Course>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCourses;
                    }
                }
            }
        }
        private ICollection<Course> _courses;

        #endregion
        #region Association Fixup
    
        private void FixupCourses(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Course item in e.NewItems)
                {
                    item.Department = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Course item in e.OldItems)
                {
                    if (ReferenceEquals(item.Department, this))
                    {
                        item.Department = null;
                    }
                }
            }
        }

        #endregion
    }
}