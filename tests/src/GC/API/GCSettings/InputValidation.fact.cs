using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GCSettings_InputValidation_InputValidation_
    {
        [Fact]
        public void _GCSettings_InputValidation_InputValidation_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GCSettings\\InputValidation\\InputValidation.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
