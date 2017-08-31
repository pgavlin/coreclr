using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _explicitlayout_Regressions_298006_explicitStruct_oddSize_explicitStruct_oddSize_
    {
        [OuterLoop]
        [Fact]
        public void _explicitlayout_Regressions_298006_explicitStruct_oddSize_explicitStruct_oddSize_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\Regressions\\298006\\explicitStruct_oddSize\\explicitStruct_oddSize.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
