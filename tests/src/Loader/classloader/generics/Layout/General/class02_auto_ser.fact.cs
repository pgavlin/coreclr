using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_class02_auto_ser_class02_auto_ser_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_class02_auto_ser_class02_auto_ser_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\class02_auto_ser\\class02_auto_ser.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
