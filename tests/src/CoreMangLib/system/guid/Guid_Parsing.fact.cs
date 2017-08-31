using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _guid_Guid_Parsing_Guid_Parsing_
    {
        [OuterLoop]
        [Fact]
        public void _guid_Guid_Parsing_Guid_Parsing_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\guid\\Guid_Parsing\\Guid_Parsing.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
