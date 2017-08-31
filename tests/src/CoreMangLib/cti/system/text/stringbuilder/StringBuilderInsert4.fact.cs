using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderInsert4_StringBuilderInsert4_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderInsert4_StringBuilderInsert4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderInsert4\\StringBuilderInsert4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
