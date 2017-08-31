using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_class02_auto_class02_auto_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_class02_auto_class02_auto_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\class02_auto\\class02_auto.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
