using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderInsert_StringBuilderInsert_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderInsert_StringBuilderInsert_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderInsert\\StringBuilderInsert.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
