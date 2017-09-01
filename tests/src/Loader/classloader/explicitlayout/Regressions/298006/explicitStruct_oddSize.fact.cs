using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _explicitlayout_Regressions_298006_explicitStruct_oddSize_explicitStruct_oddSize_
    {
        [OuterLoop]
        [Fact]
        public void _explicitlayout_Regressions_298006_explicitStruct_oddSize_explicitStruct_oddSize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\explicitlayout\\Regressions\\298006\\explicitStruct_oddSize\\explicitStruct_oddSize.cmd");
        }
    }
}
