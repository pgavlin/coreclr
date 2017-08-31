using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _version_Version_Parsing_Version_Parsing_
    {
        [OuterLoop]
        [Fact]
        public void _version_Version_Parsing_Version_Parsing_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\version\\Version_Parsing\\Version_Parsing.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
