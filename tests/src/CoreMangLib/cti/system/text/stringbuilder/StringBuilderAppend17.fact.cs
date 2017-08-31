using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderAppend17_StringBuilderAppend17_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderAppend17_StringBuilderAppend17_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderAppend17\\StringBuilderAppend17.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
