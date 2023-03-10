/* 
 * UriAttribute.cs
 * 
 *   Created: 2023-02-25-01:44:11
 *   Modified: 2023-02-25-01:45:02
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


namespace System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class UriAttribute : ValueAttribute<Uri>
{
    public UriAttribute(Uri uri) : base(uri) { }
    public UriAttribute(string uri) : this(new Uri(uri)) { }
    public Uri Uri => Value;
}
