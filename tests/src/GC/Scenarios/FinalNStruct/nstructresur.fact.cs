using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _FinalNStruct_nstructresur_nstructresur_
    {
        [Fact]
        public void _FinalNStruct_nstructresur_nstructresur_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\FinalNStruct\\nstructresur\\nstructresur.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
