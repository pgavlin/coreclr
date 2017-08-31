using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_rethrowincatchnestedinfinally_ro_rethrowincatchnestedinfinally_ro_
    {
        [Fact]
        public void _eh_nested_general_rethrowincatchnestedinfinally_ro_rethrowincatchnestedinfinally_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\rethrowincatchnestedinfinally_ro\\rethrowincatchnestedinfinally_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
