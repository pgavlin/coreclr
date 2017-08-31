using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderAppend18_StringBuilderAppend18_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderAppend18_StringBuilderAppend18_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderAppend18\\StringBuilderAppend18.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
