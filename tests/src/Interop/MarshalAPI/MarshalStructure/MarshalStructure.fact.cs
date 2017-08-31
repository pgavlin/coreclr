using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _MarshalStructure_MarshalStructure_MarshalStructure_
    {
        [Fact]
        public void _MarshalStructure_MarshalStructure_MarshalStructure_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\MarshalStructure\\MarshalStructure\\MarshalStructure.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
