/* 
 * ValueAttribute.cs
 * 
 *   Created: 2023-02-25-01:44:11
 *   Modified: 2023-02-25-01:44:54
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


namespace System.ComponentModel.DataAnnotations;

public abstract class ValueAttribute<T> : Attribute
{
    public ValueAttribute(T value) => Value = value;
    public T Value { get; }
}
