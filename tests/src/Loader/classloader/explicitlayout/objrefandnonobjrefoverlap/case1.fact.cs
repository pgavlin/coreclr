using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_objrefandnonobjrefoverlap_case1_case1_
    {
        [Fact]
        public void _explicitlayout_objrefandnonobjrefoverlap_case1_case1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\objrefandnonobjrefoverlap\\case1\\case1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
