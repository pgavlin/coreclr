using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    public class _ReadWrite_ReadWriteObject_ReadWriteObject_
    {
        [Fact]
        public void _ReadWrite_ReadWriteObject_ReadWriteObject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\MarshalAPI\\ReadWrite\\ReadWriteObject\\ReadWriteObject.cmd");
        }
    }
}
