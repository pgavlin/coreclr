using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_External_dev11_13748_ReflectOnField_ReflectOnField_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_13748_ReflectOnField_ReflectOnField_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_13748\\ReflectOnField\\ReflectOnField.cmd");
        }
    }
}
