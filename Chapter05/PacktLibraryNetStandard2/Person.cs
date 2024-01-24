﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

public class Person : object
{
    #region Fields: Data or state for this person.
    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    #endregion
}









