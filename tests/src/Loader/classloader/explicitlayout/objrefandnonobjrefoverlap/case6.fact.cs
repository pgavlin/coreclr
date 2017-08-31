using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_objrefandnonobjrefoverlap_case6_case6_
    {
        [Fact]
        public void _explicitlayout_objrefandnonobjrefoverlap_case6_case6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\objrefandnonobjrefoverlap\\case6\\case6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
