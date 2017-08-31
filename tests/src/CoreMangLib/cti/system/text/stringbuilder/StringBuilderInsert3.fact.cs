using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderInsert3_StringBuilderInsert3_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderInsert3_StringBuilderInsert3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderInsert3\\StringBuilderInsert3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
