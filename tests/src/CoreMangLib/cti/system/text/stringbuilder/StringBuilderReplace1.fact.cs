using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderReplace1_StringBuilderReplace1_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderReplace1_StringBuilderReplace1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderReplace1\\StringBuilderReplace1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
