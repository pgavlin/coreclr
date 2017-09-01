using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_threadstartarray_threadstartarray_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_threadstartarray_threadstartarray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\threadstartarray\\threadstartarray.cmd");
        }
    }
}
