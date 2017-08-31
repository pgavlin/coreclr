using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringConcat6_StringConcat6_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringConcat6_StringConcat6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringConcat6\\StringConcat6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
