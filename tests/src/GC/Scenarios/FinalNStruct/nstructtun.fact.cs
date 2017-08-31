using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _FinalNStruct_nstructtun_nstructtun_
    {
        [Fact]
        public void _FinalNStruct_nstructtun_nstructtun_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\FinalNStruct\\nstructtun\\nstructtun.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
