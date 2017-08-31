using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_General_Base02a_auto_Base02a_auto_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_General_Base02a_auto_Base02a_auto_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\General\\Base02a_auto\\Base02a_auto.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
