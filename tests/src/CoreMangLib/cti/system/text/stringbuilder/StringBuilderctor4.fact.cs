using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderctor4_StringBuilderctor4_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderctor4_StringBuilderctor4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderctor4\\StringBuilderctor4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
