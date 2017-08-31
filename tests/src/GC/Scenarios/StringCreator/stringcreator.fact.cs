using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _StringCreator_stringcreator_stringcreator_
    {
        [Fact]
        public void _StringCreator_stringcreator_stringcreator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\StringCreator\\stringcreator\\stringcreator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
