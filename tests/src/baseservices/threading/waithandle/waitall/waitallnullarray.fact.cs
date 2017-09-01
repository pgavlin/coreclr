using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_waitall_waitallnullarray_waitallnullarray_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_waitallnullarray_waitallnullarray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\waitallnullarray\\waitallnullarray.cmd");
        }
    }
}
