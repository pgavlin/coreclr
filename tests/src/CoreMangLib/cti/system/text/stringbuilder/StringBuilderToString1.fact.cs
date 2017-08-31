using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderToString1_StringBuilderToString1_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderToString1_StringBuilderToString1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderToString1\\StringBuilderToString1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
