using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_objrefandnonobjrefoverlap_case7_case7_
    {
        [Fact]
        public void _explicitlayout_objrefandnonobjrefoverlap_case7_case7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\objrefandnonobjrefoverlap\\case7\\case7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
