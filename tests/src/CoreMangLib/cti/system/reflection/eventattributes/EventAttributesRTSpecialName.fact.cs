using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_eventattributes_EventAttributesRTSpecialName_EventAttributesRTSpecialName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_eventattributes_EventAttributesRTSpecialName_EventAttributesRTSpecialName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\eventattributes\\EventAttributesRTSpecialName\\EventAttributesRTSpecialName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
