using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderChars_StringBuilderChars_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderChars_StringBuilderChars_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderChars\\StringBuilderChars.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
