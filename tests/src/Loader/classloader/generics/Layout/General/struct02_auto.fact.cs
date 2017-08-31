using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_struct02_auto_struct02_auto_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_struct02_auto_struct02_auto_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\struct02_auto\\struct02_auto.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
