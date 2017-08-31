using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_objrefandnonobjrefoverlap_case14_case14_
    {
        [Fact]
        public void _explicitlayout_objrefandnonobjrefoverlap_case14_case14_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\objrefandnonobjrefoverlap\\case14\\case14.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
