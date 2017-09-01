using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitall_waitallemptyarray_waitallemptyarray_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallemptyarray_waitallemptyarray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallemptyarray\\waitallemptyarray.cmd");
        }
    }
}
