using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _Copy_CopySingleArray_CopySingleArray_
    {
        [Fact]
        public void _Copy_CopySingleArray_CopySingleArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\Copy\\CopySingleArray\\CopySingleArray.cmd");
        }
    }
}
