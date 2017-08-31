using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _FinalNStruct_finalnstruct_finalnstruct_
    {
        [Fact]
        public void _FinalNStruct_finalnstruct_finalnstruct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\FinalNStruct\\finalnstruct\\finalnstruct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
