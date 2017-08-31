using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_objrefandnonobjrefoverlap_case4_case4_
    {
        [Fact]
        public void _explicitlayout_objrefandnonobjrefoverlap_case4_case4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\objrefandnonobjrefoverlap\\case4\\case4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
