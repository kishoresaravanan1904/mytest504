﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest504
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest504Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("71caad93-fda6-4ba8-9db4-d899b2d6cb41")]
    public partial class MyTest504Repository : RepoGenBaseFolder
    {
        static MyTest504Repository instance = new MyTest504Repository();

        /// <summary>
        /// Gets the singleton class instance representing the MyTest504Repository element repository.
        /// </summary>
        [RepositoryFolder("71caad93-fda6-4ba8-9db4-d899b2d6cb41")]
        public static MyTest504Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest504Repository() 
            : base("MyTest504Repository", "/", null, 0, false, "71caad93-fda6-4ba8-9db4-d899b2d6cb41", ".\\RepositoryImages\\MyTest504Repository71caad93.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("71caad93-fda6-4ba8-9db4-d899b2d6cb41")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest504RepositoryFolders
    {
    }
#pragma warning restore 0436
}
