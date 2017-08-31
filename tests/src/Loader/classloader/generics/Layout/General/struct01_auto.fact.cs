using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_struct01_auto_struct01_auto_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_struct01_auto_struct01_auto_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\struct01_auto\\struct01_auto.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
